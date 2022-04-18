using Newtonsoft.Json;
using RecklessBoon.MacroDeck.PhilipsHuePlugin.Actions;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls
{
    public partial class AdjustLightConfigurator : ActionConfigControl
    {
        // Add a variable for the instance of your action to get access to the Configuration etc.
        private AdjustLightAction _macroDeckAction;

        protected AdjustLightConfig _config;

        public AdjustLightConfigurator(AdjustLightAction action, ActionConfigurator actionConfigurator)
        {
            InitializeComponent();

            this._macroDeckAction = action;
            this._config = action.Configuration != null ? JsonConvert.DeserializeObject<AdjustLightConfig>(action.Configuration) : null;
            _ = PopulateBridgesAsync();
            ddlBridge.SelectedIndexChanged += (object sender, EventArgs args) =>
            {
                _ = PopulateLightsAsync();
            };
            if (this._config != null)
            {
                trkBrightness.Value = this._config.BrightnessAdjustmentPercent ?? 0;
                trkSaturation.Value = this._config.SaturationAdjustmentPercent ?? 0;
                trkHue.Value = this._config.HueAdjustmentPercent ?? 0;
                trkColorTemperature.Value = this._config.ColorTemperatureAdjustmentPercent ?? 0;
            }
        }

        private void Trackbar_Scrolled(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            toolTip1.SetToolTip(trackBar, trackBar.Value.ToString() + '%');
        }

        protected async Task PopulateBridgesAsync()
        {
            ddlBridge.Items.Clear();
            int preselectIndex = -1;
            foreach (var client in Cache.HueClients)
            {
                var bridge = await client.Value.GetBridgeAsync();
                var index = ddlBridge.Items.Add(bridge.Config.BridgeId.ToLower());
                if (this._config != null && client.Key == this._config.BridgeId)
                {
                    preselectIndex = index;
                }
            }

            if (preselectIndex >= 0)
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
                    pnlLights.Invoke((MethodInvoker)(() =>
                    {
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
                foreach (LightSelector lightSelector in pnlLights.Controls)
                {
                    if (lightSelector.Selected)
                    {
                        lightIds.Add(lightSelector.ID);
                    }
                }

                var config = new AdjustLightConfig
                {
                    BridgeId = bridgeId,
                    LightIds = lightIds,
                    BrightnessAdjustmentPercent = trkBrightness.Value != 0 ? (int?)trkBrightness.Value : null,
                    SaturationAdjustmentPercent = trkSaturation.Value != 0 ? (int?)trkSaturation.Value : null,
                    HueAdjustmentPercent = trkHue.Value != 0 ? (int?)trkHue.Value : null,
                    ColorTemperatureAdjustmentPercent = trkColorTemperature.Value != 0 ? (int?)trkColorTemperature.Value : null,
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
