using Newtonsoft.Json;
using Q42.HueApi;
using RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls;
using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using System.Collections.Generic;

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.Actions
{
    public class AdjustLightConfig
    {
        public string BridgeId { get; set; }

        public List<string> LightIds { get; set; }

        public int? BrightnessAdjustmentPercent { get; set; }

        public int? BrightnessAdjustment 
        {
            get
            {
                if (BrightnessAdjustmentPercent.HasValue)
                {
                    return (int)(2.54 * BrightnessAdjustmentPercent);
                }
                return null;
            }
        }

        public int? SaturationAdjustmentPercent { get; set; }

        public int? SaturationAdjustment
        {
            get
            {
                if (SaturationAdjustmentPercent.HasValue)
                {
                    return (int)(2.54 * SaturationAdjustmentPercent);
                }
                return null;
            }
        }

        public int? HueAdjustmentPercent { get; set; }

        public int? HueAdjustment
        {
            get
            {
                if (HueAdjustmentPercent.HasValue)
                {
                    return (int)(655.34 * HueAdjustmentPercent);
                }
                return null;
            }
        }

        public int? ColorTemperatureAdjustmentPercent { get; set; }

        public int? ColorTemperatureAdjustment
        {
            get
            {
                if (ColorTemperatureAdjustmentPercent.HasValue)
                {
                    return (int)(3.5 * ColorTemperatureAdjustmentPercent);
                }
                return null;
            }
        }
    }

    public class AdjustLightAction : PluginAction
    {
        // The name of the action
        public override string Name => "Adjust Light";

        // A short description what the action can do
        public override string Description => "Increase/Decrease a light's relative settings (Brightness, Saturation, Hue, & Color Temperature)";

        // Optional; Add if this action can be configured. This will make the ActionConfigurator calling GetActionConfigurator();
        public override bool CanConfigure => true;

        // Optional; Add if you added CanConfigure; Gets called when the action can be configured and the action got selected in the ActionSelector. You need to return a user control with the "ActionConfigControl" class as base class
        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new AdjustLightConfigurator(this, actionConfigurator);
        }

        // Gets called when the action is triggered by a button press or an event
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            var config = JsonConvert.DeserializeObject<AdjustLightConfig>(this.Configuration);

            var command = new LightCommand()
            {
                BrightnessIncrement       = config.BrightnessAdjustment,
                SaturationIncrement       = config.SaturationAdjustment,
                HueIncrement              = config.HueAdjustment,
                ColorTemperatureIncrement = config.ColorTemperatureAdjustment,
            };
            var client = Cache.HueClients[config.BridgeId];
            _ = client.SendCommandAsync(command, config.LightIds);
        }

        // Optional; Gets called when the action button gets deleted
        public override void OnActionButtonDelete()
        {

        }

        // Optional; Gets called when the action button is loaded
        public override void OnActionButtonLoaded()
        {

        }
    }
}
