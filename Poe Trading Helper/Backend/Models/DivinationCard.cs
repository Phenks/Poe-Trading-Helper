using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace PoeTradingHelper.Backend.Models
{
    public class DivinationCard : Item
    {
        [JsonProperty("stackSize")]
        public int CardsPerSet { get; set; }
        
    }
}
