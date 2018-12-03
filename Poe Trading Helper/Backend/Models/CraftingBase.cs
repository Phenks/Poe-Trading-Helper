using Newtonsoft.Json;

namespace PoeTradingHelper.Backend.Models
{
    public class CraftingBase : Equipment
    {
        [JsonProperty("levelRequired")] public int ItemLevel { get; set; }

        public bool Shaper { get; private set; }
        public bool Elder { get; private set; }

        [JsonProperty("variant")]
        public string ShaperElderInput
        {
            set
            {
                if (value == "Shaper")
                    Shaper = true;
                else if (value == "Elder")
                    Elder = true;
            }
        }
    }
}