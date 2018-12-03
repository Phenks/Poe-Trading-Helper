using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PoeTradingHelper.Backend.Models
{
    public class Flask : Item
    {
        public string AdditonalInformation { get; private set; }

        [JsonProperty("variant")]
        public string Variant
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value) == false)
                {
                    AdditonalInformation = value;
                    this.Name += " " + value.Replace(" ", "_").Replace("'", "").Replace("-", "_");
                }

            }
        }
    }
}
