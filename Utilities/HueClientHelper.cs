using Q42.HueApi;
using Q42.HueApi.Interfaces;
using System;
using System.Threading.Tasks;

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.Utilities
{
    class HueClientHelper
    {
        public class ClientConnectedArgs : EventArgs
        {
            public ILocalHueClient Client { get; set; }
            public string BridgeId { get; set; }
            public string AppKey { get; set; }
        }
        public static event EventHandler<ClientConnectedArgs> OnClientConnected;

        public static async Task ConnectClient(ILocalHueClient client, string bridgeId, string appKey)
        {
            client.Initialize(appKey);
            if (await client.CheckConnection())
            {
                OnClientConnected?.Invoke(null, new ClientConnectedArgs { Client = client, BridgeId = bridgeId, AppKey = appKey });
            }
        }
        
    }
}
