using Q42.HueApi;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Bridge;
using RecklessBoon.MacroDeck.PhilipsHuePlugin.GUI.Dialog;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin
{
    public class PhilipsHuePlugin : MacroDeckPlugin
    {
        public override bool CanConfigure => true;

        public PhilipsHuePlugin()
        {
            Cache.Plugin ??= this;
        }

        public override void Enable()
        {
            
        }

        public override void OpenConfigurator()
        {
            using (var configurator = new Configurator(new HttpBridgeLocator()))
            {
                configurator.ShowDialog();
            }
        }

    }
}
