using Newtonsoft.Json;
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
    public partial class AdjustBrightnessConfigurator : ActionConfigControl
    {
        // Add a variable for the instance of your action to get access to the Configuration etc.
        private AdjustBrightnessAction _macroDeckAction;

        protected AdjustBrightnessConfig _config;

        public AdjustBrightnessConfigurator(AdjustBrightnessAction action, ActionConfigurator actionConfigurator)
        {
            InitializeComponent();
            this._macroDeckAction = action;
            this._config = action.Configuration != null ? JsonConvert.DeserializeObject<AdjustBrightnessConfig>(action.Configuration) : null;
            _ = PopulateBridgesAsync();
            ddlBridge.SelectedIndexChanged += (object sender, EventArgs args) =>
            {
                _ = PopulateLightsAsync();
            };
            if (this._config != null)
            {
                trkBrightness.Value = this._config.AdjustmentPercent;
            }
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

                var config = new AdjustBrightnessConfig
                {
                    BridgeId = bridgeId,
                    LightIds = lightIds,
                    AdjustmentPercent = trkBrightness.Value
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
