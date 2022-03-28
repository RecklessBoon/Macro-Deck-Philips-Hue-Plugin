﻿using Newtonsoft.Json;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Bridge;
using RecklessBoon.MacroDeck.PhilipsHuePlugin.Actions;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls
{
    public partial class UpdateLightConfigurator : ActionConfigControl
    {
        // Add a variable for the instance of your action to get access to the Configuration etc.
        private UpdateLightAction _macroDeckAction;

        protected UpdateLightConfig _config;

        public UpdateLightConfigurator(UpdateLightAction action, ActionConfigurator actionConfigurator)
        {
            this._macroDeckAction = action;
            this._config = action.Configuration != null ? JsonConvert.DeserializeObject<UpdateLightConfig>(action.Configuration) : null;
            InitializeComponent();
            _ = PopulateBridgesAsync();
            ddlBridge.SelectedIndexChanged += (object sender, EventArgs args) =>
            {
                _ = PopulateLightsAsync();
            };
            if (this._config != null)
            {
                cbxOnOff.Checked = this._config.isOn;
                colorDialog1.Color = this._config.color;
                btnColorSelector.BackColor = this._config.color;
            }

            btnColorSelector.Click += (sender, args) =>
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btnColorSelector.BackColor = colorDialog1.Color;
                };
            };
        }

        protected async Task PopulateBridgesAsync()
        {
            ddlBridge.Items.Clear();
            int preselectIndex = -1;
            foreach(var client in Cache.HueClients)
            {
                var bridge = await client.Value.GetBridgeAsync();
                var index = ddlBridge.Items.Add(bridge.Config.BridgeId.ToLower());
                if (this._config != null && client.Key == this._config.BridgeId)
                {
                    preselectIndex = index;
                }
            }

            if (preselectIndex >=0 )
            {
                ddlBridge.SelectedIndex = preselectIndex;
            }
        }

        protected async Task PopulateLightsAsync()
        {
            pnlLights.Controls.Clear();
            var bridgeId = (string)ddlBridge.Items[ddlBridge.SelectedIndex];
            var client = Cache.HueClients[bridgeId];
            if (client != null)
            {
                var lights = await client.GetLightsAsync();
                foreach (var light in lights)
                {
                    var lightSelector = new LightSelector(light.Id, light.Name, light);
                    pnlLights.Invoke((MethodInvoker)(() => {
                        if (this._config != null && this._config.LightIds.Contains(light.Id))
                        {
                            lightSelector.Selected = true;
                        }
                        pnlLights.Controls.Add(lightSelector);
                    }));
                    lightSelector.OnSelectedChanged += (object sender, SelectedChangedEventArgs e) =>
                    {
                        if (e.Selected)
                        {
                            _ = client.SendCommandAsync(new Q42.HueApi.LightCommand() { Alert = Q42.HueApi.Alert.Once }, new List<string>() { light.Id });
                        }
                    };
                }
            }
        }

        public override bool OnActionSave()
        {
            if (ddlBridge.SelectedIndex < 0)
            {
                return false; // Return false if the user has not filled out the text box
            }
            try
            {
                var bridgeId = (string)ddlBridge.Items[ddlBridge.SelectedIndex];
                var lightIds = new List<string>();
                foreach(LightSelector lightSelector in pnlLights.Controls)
                {
                    if (lightSelector.Selected)
                    {
                        lightIds.Add(lightSelector.ID);
                    }
                }

                var config = new UpdateLightConfig
                {
                    BridgeId = bridgeId,
                    LightIds = lightIds,
                    color = colorDialog1.Color,
                    isOn = cbxOnOff.Checked
                };
                var json = JsonConvert.SerializeObject(config);
                this._macroDeckAction.ConfigurationSummary = config.BridgeId; // Set a summary of the configuration that gets displayed in the ButtonConfigurator item
                this._macroDeckAction.Configuration = json;
            }
            catch { }
            return true; // Return true if the action was configured successfully; This closes the ActionConfigurator
        }

    }
}