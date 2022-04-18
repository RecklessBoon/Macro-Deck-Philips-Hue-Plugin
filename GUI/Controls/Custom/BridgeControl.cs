using Q42.HueApi;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Bridge;
using RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Dialog;
using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using RecklessBoon.MacroDeck.PhilipsHuePlugin.Utilities;

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls
{
    public partial class BridgeControl : UserControl
    {
        public LocatedBridge bridge = null;

        private bool _isConnected = false;
        public bool IsConnected
        {
            get { return _isConnected; }
            set 
            { 
                if (value == true)
                {
                    btnConnect.Text = "Connected";
                    btnConnect.Enabled = false;
                } else
                {
                    btnConnect.Text = "Connect...";
                    btnConnect.Enabled = true;
                }
                _isConnected = value; 
            }
        }

        public BridgeControl(LocatedBridge bridge)
        {
            InitializeComponent();
            this.bridge = bridge;

            if (Cache.HueClients.ContainsKey(bridge.BridgeId))
            {
                Task.Run(async () =>
                {
                    if (await Cache.HueClients[bridge.BridgeId].CheckConnection())
                    {
                        IsConnected = true;
                    }
                });
            } 
            else if (Cache.BridgeKeys.Count > 0 && Cache.BridgeKeys.ContainsKey(bridge.BridgeId))
            {
                var appKey = Cache.BridgeKeys[bridge.BridgeId];
                Task.Run(async () =>
                {
                    ILocalHueClient client = new LocalHueClient(bridge.IpAddress);
                    await HueClientHelper.ConnectClient(client, bridge.BridgeId, appKey);
                    IsConnected = true;
                });
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (bridge != null)
            {
                _ = ConnectBridgeAsync();
            }
        }

        protected async Task ConnectBridgeAsync()
        {
            prgTimer.Value = 0;
            splitContainer1.Panel1Collapsed = true;
            splitContainer1.Panel2Collapsed = false;
            var cts = new CancellationTokenSource();
            _ = Task.Run(() =>
            {
                var time = 0;
                while (time < 30 && !cts.Token.IsCancellationRequested)
                {
                    if (!prgTimer.IsDisposed)
                    {
                        prgTimer.Invoke((MethodInvoker)(() =>
                        {
                            prgTimer.Value += 1;
                        }));
                    }
                    Thread.Sleep(1000);
                    time++;
                }
            }, cts.Token);

            ILocalHueClient client = new LocalHueClient(bridge.IpAddress);

            try
            {
                var count = 0;
                Cache.BridgeKeys.TryGetValue(bridge.BridgeId, out string appKey);
                while (appKey == null && count < 30)
                {
                    try
                    {
                        appKey = await client.RegisterAsync("Macro_Deck_2", Environment.MachineName[..Math.Min(Environment.MachineName.Length, 19)]);
                        IsConnected = true;
                        cts.Cancel();
                    }
                    catch (LinkButtonNotPressedException) {}
                    Thread.Sleep(1000);
                    count++;
                }

                if (!IsConnected)
                {
                    MacroDeckLogger.Error(Cache.Plugin, "Unable to connect to bridge. Button was not pressed in time... please try again.");
                    if (Cache.HueClients.ContainsKey(bridge.BridgeId))
                        Cache.HueClients.Remove(bridge.BridgeId);
                }
                else if (appKey != null)
                {
                    _ = HueClientHelper.ConnectClient(client, bridge.BridgeId, appKey);
                }
                splitContainer1.Panel1Collapsed = false;
                splitContainer1.Panel2Collapsed = true;
            } catch (Exception) { }    
        }
    }
}
