using Q42.HueApi.Interfaces;
using System.Collections.Generic;

namespace RecklessBoon.MacroDeck.PhilipsHuePlugin
{
    public static class Cache
    {
        public static PhilipsHuePlugin Plugin;
        public static Dictionary<string, string> BridgeKeys;
        public static Dictionary<string, ILocalHueClient> HueClients;
    }
}
