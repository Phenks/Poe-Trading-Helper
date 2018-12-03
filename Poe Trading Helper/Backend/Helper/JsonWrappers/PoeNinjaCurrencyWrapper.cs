using System.Collections.Generic;
using Newtonsoft.Json;
using PoeTradingHelper.Backend.Models;

namespace PoeTradingHelper.Backend.Helper.JsonWrappers
{
    public class PoeNinjaWrapper
    {
        public class DivinationCard
        {
            [JsonProperty("lines")] public List<Models.DivinationCard> Data { get; set; }
        }

        public class Weapon
        {
            [JsonProperty("lines")] public List<Models.Weapon> Data { get; set; }
        }
        public class Armour
        {
            [JsonProperty("lines")] public List<Models.Armour> Data { get; set; }
        }
        public class Accessory
        {
            [JsonProperty("lines")] public List<Models.Accessory> Data { get; set; }
        }

        public class CraftingBase
        {
            [JsonProperty("lines")] public List<Models.CraftingBase> Data { get; set; }
        }

        public class Flask
        {
            [JsonProperty("lines")] public List<Models.Flask> Data { get; set; }

        }

        public class Prophecy
        {
            [JsonProperty("lines")] public List<Models.Prophecy> Data { get; set; }

        }


        public class Currency
        {
            [JsonProperty("lines")] public List<RatioOuter> CurrencyRatios { get; set; }

            [JsonProperty("currencyDetails")] public List<CurrencyType> CurrencyTypes { get; set; }

            public class CurrencyType
            {
                [JsonProperty("icon")] public string IconUrl { get; set; }

                [JsonProperty("id")] public int PoeNinjaId { get; set; }

                [JsonProperty("name")] public string Name { get; set; }

                [JsonProperty("poeTradeId")] public int PoeTradeId { get; set; }
            }

            public class RatioOuter
            {
                [JsonProperty("pay")] public RatioInner PayRatio { get; set; }

                [JsonProperty("receive")] public RatioInner SellRatio { get; set; }

                [JsonProperty("chaosEquivalent")] public float PriceInChaos { get; set; }

                [JsonProperty("currencyTypeName")] public string Name { get; set; }

                public class RatioInner
                {
                    [JsonProperty("pay_currency_id")] public int PayCurrencyId { get; set; }

                    [JsonProperty("get_currency_id")] public int GetCurrencyId { get; set; }

                    [JsonProperty("value")] public float PayAmount { get; set; }
                }
            }

        }
        


    }





}