using Q42.HueApi;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Bridge;
using RecklessBoon.MacroDeck.PhilipsHuePlugin.Actions;
using RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Dialog;
using RecklessBoon.MacroDeck.PhilipsHuePlugin.Utilities;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RecklessBoon.MacroDeck.PhilipsHuePlugin.Utilities.HueClientHelper;

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin
{
    public class PhilipsHuePlugin : MacroDeckPlugin
    {
        public override bool CanConfigure => true;

        public PhilipsHuePlugin()
        {
            Cache.Plugin ??= this;
            Cache.HueClients = new Dictionary<string, ILocalHueClient>();
        }

        private void HueClientHelper_OnClientConnected(object sender, ClientConnectedArgs args)
        {
            Cache.HueClients[args.BridgeId] = args.Client;
            Cache.BridgeKeys[args.BridgeId] = args.AppKey;
            PluginCredentials.SetCredentials(Cache.Plugin, Cache.BridgeKeys);
        }

        public override void Enable()
        {
            var creds = PluginCredentials.GetPluginCredentials(Cache.Plugin);
            Cache.BridgeKeys = creds != null && creds.Count > 0 ? creds.First() : new Dictionary<string, string>();
            HueClientHelper.OnClientConnected += HueClientHelper_OnClientConnected;
            _ = ConnectPreviousClients();

            Task.Run(async () => {
                var bridges = await (new HttpBridgeLocator()).LocateBridgesAsync(TimeSpan.FromSeconds(5));

                foreach (var bridge in bridges)
                {
                    if (Cache.BridgeKeys.ContainsKey(bridge.BridgeId)) {
                        var client = new LocalHueClient(bridge.IpAddress, Cache.BridgeKeys[bridge.BridgeId]);
                        if (await client.CheckConnection())
                        {
                            Cache.HueClients[bridge.BridgeId] = client;
                        }
                    }
                }
            });

            this.Actions = new List<PluginAction> {
                new SetSceneAction(),
                new UpdateLightAction(),
                new AdjustBrightnessAction(),
            };
        }

        public override void OpenConfigurator()
        {
            using (var configurator = new Configurator(new HttpBridgeLocator()))
            {
                configurator.ShowDialog();
            }
        }

        protected async Task ConnectPreviousClients()
        {
            var Locator = new HttpBridgeLocator();
            var bridges = await Locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));
            foreach (var bridge in bridges)
            {
                if (Cache.BridgeKeys.ContainsKey(bridge.BridgeId))
                {
                    var client = new LocalHueClient(bridge.IpAddress);
                    _ = HueClientHelper.ConnectClient(client, bridge.BridgeId, Cache.BridgeKeys[bridge.BridgeId]);
                }
            }
        }

    }
}
