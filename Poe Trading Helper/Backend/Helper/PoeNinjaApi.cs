using System;
using System.Collections.Generic;
using System.Linq;
using PoeTradingHelper.Backend.Helper.JsonWrappers;
using PoeTradingHelper.Backend.Models;

namespace PoeTradingHelper.Backend.Helper
{
    public class PoeNinjaApi
    {
        public PoeNinjaApi()
        {
            WebRequestManager = new WebRequestHandler();
            PoeNinjaApiUrlBuilder = new PoeNinjaApiUrlBuilder(PoeNinjaApiUrlBuilder.League.CurrentScLeague);
        }

        public WebRequestHandler WebRequestManager { get; set; }
        public PoeNinjaApiUrlBuilder PoeNinjaApiUrlBuilder { get; }


        #region GetCurrencies

        public List<Currency> GetCurrencies()
        {
            const int ExaltedOrbId = 2;

            var url = PoeNinjaApiUrlBuilder.BuildUrl(PoeNinjaApiUrlBuilder.Category.CurrencyRatios);
            PoeNinjaWrapper.Currency currencyWrapper =
                WebRequestManager.GetWebRequestDataAsJson<PoeNinjaWrapper.Currency>(url);

            var Currencies = new List<Currency>();

            InitializeCurrenciesWithBaseData(currencyWrapper, Currencies);
            FillInPriceInChaos(currencyWrapper, Currencies);
            CalculateExaltedRatio(ExaltedOrbId, Currencies);

            return Currencies;
        }

        private void CalculateExaltedRatio(int ExaltedOrbId, List<Currency> Currencies)
        {
            Currency exaltedOrb = Currencies.First(c => c.PoeNinjaId == ExaltedOrbId);
            var chaosToExaltedRatio = exaltedOrb.PriceInChaos;


            foreach (Currency currency in Currencies)
                currency.PriceInExalted = CurrencyConverter.CalculatePriceInExalted(currency, chaosToExaltedRatio);
        }

        private void FillInPriceInChaos(PoeNinjaWrapper.Currency currencyWrapper, List<Currency> Currencies)
        {
            foreach (var currencyRatioWrapper in currencyWrapper.CurrencyRatios)
            {
                //var poeNinjaId = currencyRatioWrapper.PayRatio.PayCurrencyId;
                Currency currency = Currencies.First(c => c.Name == currencyRatioWrapper.Name);
                currency.PriceInChaos = currencyRatioWrapper.PriceInChaos;
            }
        }

        private void InitializeCurrenciesWithBaseData(PoeNinjaWrapper.Currency currencyWrapper, List<Currency> Currencies)
        {
            // Create a currency and fill in the base data
            foreach (var currencyBaseData in currencyWrapper.CurrencyTypes)
                Currencies.Add(
                    new Currency
                    {
                        Name = currencyBaseData.Name,
                        PoeNinjaId = currencyBaseData.PoeNinjaId,
                        IconUrl = currencyBaseData.IconUrl,
                        PoeTradeId = currencyBaseData.PoeTradeId
                    }
                );
        }

        #endregion

        public List<DivinationCard> GetDivinationCards()
        {
            var url = PoeNinjaApiUrlBuilder.BuildUrl(PoeNinjaApiUrlBuilder.Category.DivinationCards);
            var divinationCardsWrapper =
                WebRequestManager.GetWebRequestDataAsJson<PoeNinjaWrapper.DivinationCard>(url);
            return divinationCardsWrapper.Data;
        }

        public List<Weapon> GetWeapons()
        {
            var url = PoeNinjaApiUrlBuilder.BuildUrl(PoeNinjaApiUrlBuilder.Category.Weapons);
            var weaponsWrapper =
                WebRequestManager.GetWebRequestDataAsJson<PoeNinjaWrapper.Weapon>(url);
            return weaponsWrapper.Data;
        }

        public List<Armour> GetArmours()
        {
            var url = PoeNinjaApiUrlBuilder.BuildUrl(PoeNinjaApiUrlBuilder.Category.Armour);
            var armourWrapper =
                WebRequestManager.GetWebRequestDataAsJson<PoeNinjaWrapper.Armour>(url);
            return armourWrapper.Data;
        }

        public List<Accessory> GetAccessories()
        {
            var url = PoeNinjaApiUrlBuilder.BuildUrl(PoeNinjaApiUrlBuilder.Category.Accessory);
            var accessoryWrapper =
                WebRequestManager.GetWebRequestDataAsJson<PoeNinjaWrapper.Accessory>(url);
            return accessoryWrapper.Data;
        }

        public List<Prophecy> GetProphecies()
        {
            var url = PoeNinjaApiUrlBuilder.BuildUrl(PoeNinjaApiUrlBuilder.Category.Prophecies);
            var prophecyWrapper =
                WebRequestManager.GetWebRequestDataAsJson<PoeNinjaWrapper.Prophecy>(url);
            return prophecyWrapper.Data;
        }
        public List<Flask> GetFlasks()
        {
            var url = PoeNinjaApiUrlBuilder.BuildUrl(PoeNinjaApiUrlBuilder.Category.Flask);
            var flasksWrapper =
                WebRequestManager.GetWebRequestDataAsJson<PoeNinjaWrapper.Flask>(url);
            return flasksWrapper.Data;
        }

        public List<CraftingBase> GetCraftingBases()
        {
            var url = PoeNinjaApiUrlBuilder.BuildUrl(PoeNinjaApiUrlBuilder.Category.CraftingBases);
            var craftingBase =
                WebRequestManager.GetWebRequestDataAsJson<PoeNinjaWrapper.CraftingBase>(url);
            return craftingBase.Data;
        }


    }

    public class PoeNinjaApiUrlBuilder
    {
        #region Constants

        private const string BaseUrl = "https://poe.ninja/api/data/";

        #endregion

        public PoeNinjaApiUrlBuilder(League league)
        {
            SelectedLeague = league;
        }

        private League SelectedLeague { get; }

        public string BuildUrl(Category category)
        {
            var currentDate = DateTime.Today.ToString("yyyy-MM-dd");
            return
                $"{BaseUrl}{category.ApiCall}?type={category.TypeParameter}&league={SelectedLeague}&Date={currentDate}";
        }

        public sealed class League
        {
            public static readonly League CurrentScLeague = new League("Delve");
            public static readonly League TestLeague = new League("test");
            private readonly string league;

            private League(string leagueName)
            {
                league = leagueName;
            }


            public override string ToString()
            {
                return league;
            }

            public static implicit operator string(League league)
            {
                return league.ToString();
            }
        }

        public sealed class Category
        {
            private class ApiCalls
            {
                public const string ItemOverview = "itemoverview";
                public const string CurrencyOverview = "currencyoverview";
            }


            public static readonly Category CurrencyRatios = new Category(ApiCalls.CurrencyOverview, "Currency");
            public static readonly Category DivinationCards = new Category(ApiCalls.ItemOverview, "DivinationCard");
            public static readonly Category CraftingBases = new Category(ApiCalls.ItemOverview,"BaseType");
            public static readonly Category Prophecies = new Category(ApiCalls.ItemOverview,"Prophecy");
            public static readonly Category Gems = new Category(ApiCalls.ItemOverview ,"SkillGem");
            public static readonly Category Weapons = new Category(ApiCalls.ItemOverview, "UniqueWeapon");
            public static readonly Category Armour = new Category(ApiCalls.ItemOverview, "UniqueArmour");
            public static readonly Category Accessory = new Category(ApiCalls.ItemOverview,"UniqueAccessory");
            public static readonly Category Flask = new Category(ApiCalls.ItemOverview, "UniqueFlask");
            public static readonly Category Jewel = new Category(ApiCalls.ItemOverview ,"UniqueJewel");
            public static readonly Category Fragment = new Category(ApiCalls.CurrencyOverview ,"Fragment");
            

            private Category(string apiCall, string typeParameter)
            {
                ApiCall = apiCall;
                TypeParameter = typeParameter;
            }
           
            

            public string ApiCall { get; }
            public string TypeParameter { get; }
        }
    }
}