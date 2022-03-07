using Q42.HueApi.Interfaces;
using RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Controls;
using SuchByte.MacroDeck.GUI.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Dialog
{
    public partial class Configurator : DialogForm
    {
        protected IBridgeLocator Locator;

        public Configurator(IBridgeLocator locator)
        {
            InitializeComponent();
            Locator = locator;
            this.Load += Configurator_Load;
        }

        private void Configurator_Load(object sender, EventArgs e)
        {
            _ = LoadBridges();
        }

        protected async Task LoadBridges()
        {
            var bridges = await Locator.LocateBridgesAsync(TimeSpan.FromSeconds(5));
            foreach(var bridge in bridges)
            {
                var bridgeControl = new BridgeControl(bridge);
                bridgeControl.Width = pnlBridges.ClientRectangle.Width;
                bridgeControl.lblTitle.Text = bridge.ToString();
                pnlBridges.Controls.Add(bridgeControl);
            }
        }
    }
}
