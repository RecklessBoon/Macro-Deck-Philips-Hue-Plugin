using Newtonsoft.Json;
using Q42.HueApi.Models;
using Q42.HueApi.Models.Groups;
using RecklessBoon.MacroDeck.PhilipsHuePlugin.Actions;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using System;
using System.Threading.Tasks;

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls
{
    public partial class SetSceneConfigurator : ActionConfigControl
    {
        class SceneOption
        {
            public Scene Scene { get; set; }

            public int Value
            {
                get
                {
                    int.TryParse(Scene.Id, out var sceneId);
                    return sceneId;
                }
            }

            public SceneOption(Scene scene) => Scene = scene;

            public override string ToString() => Scene.Name ?? "";
        }

        class GroupOption
        {
            public Group Group { get; set; }

            public int Value
            {
                get
                {
                    int.TryParse(Group.Id, out var groupId);
                    return groupId;
                }
            }

            public GroupOption(Group group) => Group = group;

            public override string ToString() => Group.Name ?? "";
        }

        // Add a variable for the instance of your action to get access to the Configuration etc.
        private SetSceneAction _macroDeckAction;

        protected SetSceneConfig _config;

        public SetSceneConfigurator(SetSceneAction action, ActionConfigurator actionConfigurator)
        {
            InitializeComponent();
            _macroDeckAction = action;
            _config = action.Configuration != null ? JsonConvert.DeserializeObject<SetSceneConfig>(action.Configuration) : null;
            _ = PopulateBridgesAsync();
            ddlBridge.SelectedIndexChanged += (object sender, EventArgs args) =>
            {
                _ = PopulateScenesAsync();
                _ = PopulateRoomsAsync();
            };
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

        protected async Task PopulateScenesAsync()
        {
            ddlScene.Items.Clear();
            var bridgeId = (string)ddlBridge.Items[ddlBridge.SelectedIndex];
            var client = Cache.HueClients[bridgeId];
            if (client != null)
            {
                var scenes = await client.GetScenesAsync();
                var preselectIdx = -1;
                var idx = 0;
                foreach (var scene in scenes)
                {
                    ddlScene.Items.Add(new SceneOption(scene));
                    if (_config != null && _config.SceneId == scene.Id)
                    {
                        preselectIdx = idx;
                    }
                    idx++;
                }
                if (preselectIdx >= 0)
                {
                    ddlScene.SelectedIndex = preselectIdx;
                }
            }
        }

        protected async Task PopulateRoomsAsync()
        {
            ddlRoom.Items.Clear();
            var bridgeId = (string)ddlBridge.Items[ddlBridge.SelectedIndex];
            var client = Cache.HueClients[bridgeId];
            if (client != null)
            {
                var groups = await client.GetGroupsAsync();
                var preselectIdx = -1;
                var idx = 0;
                foreach (var group in groups)
                {
                    ddlRoom.Items.Add(new GroupOption(group));
                    if (_config != null && _config.GroupId == group.Id)
                    {
                        preselectIdx = idx;
                    }
                    idx++;
                }
                if (preselectIdx >= 0)
                {
                    ddlRoom.SelectedIndex = preselectIdx;
                }
            }
        }

        public override bool OnActionSave()
        {
            if (ddlBridge.SelectedIndex < 0 || ddlScene.SelectedIndex < 0)
            {
                return false; // Return false if the user has not filled out the text box
            }
            try
            {
                var bridgeId = (string)ddlBridge.Items[ddlBridge.SelectedIndex];
                var scene = (ddlScene.Items[ddlScene.SelectedIndex] as SceneOption).Scene;
                var room = (ddlRoom.Items[ddlRoom.SelectedIndex] as GroupOption).Group;

                var config = new SetSceneConfig
                {
                    BridgeId = bridgeId,
                    SceneId = scene.Id,
                    GroupId = room.Id
                };
                var json = JsonConvert.SerializeObject(config);
                this._macroDeckAction.ConfigurationSummary = scene.Name; // Set a summary of the configuration that gets displayed in the ButtonConfigurator item
                this._macroDeckAction.Configuration = json;
            }
            catch { }
            return true; // Return true if the action was configured successfully; This closes the ActionConfigurator
        }
    }
}
