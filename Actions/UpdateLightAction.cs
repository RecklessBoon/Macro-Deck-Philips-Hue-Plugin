using Newtonsoft.Json;
using Q42.HueApi;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.ColorConverters.Original;
using RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls;
using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.Actions
{
    public class UpdateLightConfig
    {
        public string BridgeId { get; set; }

        public List<string> LightIds { get; set; }

        public Color? color { get; set; }
        public bool? isOn { get; set; }

        public byte? Brightness { get; set; }

        public TimeSpan? TransitionTime { get; set; }
    }

    public class UpdateLightAction : PluginAction
    {
        // The name of the action
        public override string Name => "Update light";

        // A short description what the action can do
        public override string Description => "Change a Hue light";

        // Optional; Add if this action can be configured. This will make the ActionConfigurator calling GetActionConfigurator();
        public override bool CanConfigure => true;

        // Optional; Add if you added CanConfigure; Gets called when the action can be configured and the action got selected in the ActionSelector. You need to return a user control with the "ActionConfigControl" class as base class
        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new UpdateLightConfigurator(this, actionConfigurator);
        }

        // Gets called when the action is triggered by a button press or an event
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            var config = JsonConvert.DeserializeObject<UpdateLightConfig>(this.Configuration);

            var command = new LightCommand()
            {
                On = config.isOn,
                Brightness = config.Brightness,
                TransitionTime = config.TransitionTime
            };
            if (config.color != default)
            {
                command.SetColor(new RGBColor(config.color.Value.R, config.color.Value.G, config.color.Value.B));
            }
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
