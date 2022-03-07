using Q42.HueApi;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Bridge;
using RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Dialog;
using SuchByte.MacroDeck.Logging;
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

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls
{
    public partial class BridgeControl : UserControl
    {
        public LocatedBridge bridge = null;

        public BridgeControl(LocatedBridge bridge)
        {
            InitializeComponent();
            this.bridge = bridge;
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
            var notifier = new ButtonPressNotifier();
            notifier.Show();
            ILocalHueClient client = new LocalHueClient(bridge.IpAddress);

            try
            {
                var count = 0;
                var backout = false;
                var buttonNotPressed = true;
                while (count < 30 || backout)
                {
                    try
                    {
                        var appKey = await client.RegisterAsync("Macro_Deck_2", Environment.MachineName[..Math.Min(Environment.MachineName.Length, 19)]);
                        buttonNotPressed = false;
                        notifier.Close();
                        client.Initialize(appKey);
                        Cache.HueClient = client;
                        backout = true;
                    }
                    catch (LinkButtonNotPressedException) {}
                    Thread.Sleep(1000);
                    count++;
                }

                if (buttonNotPressed)
                {
                    MacroDeckLogger.Error(Cache.Plugin, "Unable to connect to bridge. Button was not pressed in time... please try again.");
                }
            } catch (Exception) { }    
        }
    }
}
