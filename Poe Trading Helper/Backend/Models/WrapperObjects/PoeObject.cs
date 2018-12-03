using Newtonsoft.Json;
using PoeTradingHelper.Backend.Models.WrapperObjects;

namespace PoeTradingHelper.Backend.Models
{
    public abstract class PoeObject : Base
    {
        

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("chaosValue")] public float PriceInChaos { get; set; }

        [JsonProperty("exaltedValue")] public float PriceInExalted { get; set; }

        [JsonProperty("icon")] public string IconUrl { get; set; }
    }
}