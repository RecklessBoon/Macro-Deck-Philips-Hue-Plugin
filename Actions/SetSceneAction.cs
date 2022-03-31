using Newtonsoft.Json;
using Q42.HueApi;
using Q42.HueApi.Models;
using Q42.HueApi.Models.Groups;
using RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls;
using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.Actions
{
    public class SetSceneConfig
    {
        public string BridgeId { get; set; }

        public string SceneId { get; set; }

        public string GroupId { get; set; }
    }

    public class SetSceneAction : PluginAction
    {
        // The name of the action
        public override string Name => "Set Scene";

        // A short description what the action can do
        public override string Description => "Activate a stored scene on a specified room";

        // Optional; Add if this action can be configured. This will make the ActionConfigurator calling GetActionConfigurator();
        public override bool CanConfigure => true;

        // Optional; Add if you added CanConfigure; Gets called when the action can be configured and the action got selected in the ActionSelector. You need to return a user control with the "ActionConfigControl" class as base class
        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new SetSceneConfigurator(this, actionConfigurator);
        }

        // Gets called when the action is triggered by a button press or an event
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            var config = JsonConvert.DeserializeObject<SetSceneConfig>(Configuration);
            var client = Cache.HueClients[config.BridgeId];
            _ = client.RecallSceneAsync(config.SceneId, config.GroupId);
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
