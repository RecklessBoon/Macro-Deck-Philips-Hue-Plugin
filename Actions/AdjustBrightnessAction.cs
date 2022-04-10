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
    public class AdjustBrightnessConfig
    {
        public string BridgeId { get; set; }

        public List<string> LightIds { get; set; }

        public int AdjustmentPercent { get; set; }

        public int Adjustment 
        {
            get
            {
                return (int)(2.55 * AdjustmentPercent);
            }
        }
    }

    public class AdjustBrightnessAction : PluginAction
    {
        // The name of the action
        public override string Name => "Adjust Light Brightness";

        // A short description what the action can do
        public override string Description => "Increase/Decrease a light's brightness by a relative amount";

        // Optional; Add if this action can be configured. This will make the ActionConfigurator calling GetActionConfigurator();
        public override bool CanConfigure => true;

        // Optional; Add if you added CanConfigure; Gets called when the action can be configured and the action got selected in the ActionSelector. You need to return a user control with the "ActionConfigControl" class as base class
        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new AdjustBrightnessConfigurator(this, actionConfigurator);
        }

        // Gets called when the action is triggered by a button press or an event
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            var config = JsonConvert.DeserializeObject<AdjustBrightnessConfig>(this.Configuration);

            var command = new LightCommand()
            {
                BrightnessIncrement = config.Adjustment
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
