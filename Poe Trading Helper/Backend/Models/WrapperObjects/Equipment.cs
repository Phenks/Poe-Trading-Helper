using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PoeTradingHelper.Backend.Models
{
    public class Equipment : Item
    {
        [JsonProperty("baseType")]
        public string BaseType { get; set; }
        [JsonProperty("links")]
        public int Links { get; set; }
        [JsonProperty("corrupted")]
        public bool Corrupted { get; set; }
    }
}
