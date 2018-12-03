using Newtonsoft.Json;

namespace PoeTradingHelper.Backend.Models
{
    public class Item : PoeObject
    {
        

        [JsonProperty("flavourText")] public string FlavourText { get; set; }

        [JsonProperty("artFilename")] public string ArtFileName { get; set; }

        [JsonProperty("id")] public int InGameId { get; set; }
    }
}