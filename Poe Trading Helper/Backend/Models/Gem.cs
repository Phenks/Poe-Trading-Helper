using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PoeTradingHelper.Backend.Models
{
    public class Gem : Item
    {
        [JsonProperty("gemQuality")]
        public int Quality { get; set; }
        [JsonProperty("gemLevel")]
        public int Level { get; set; }
        [JsonProperty("corrupted")]
        public bool Corrupted { get; set; }
    }
}
