using System.Linq;
using System.Runtime.InteropServices;
using PoeTradingHelper.Backend.DAL;
using PoeTradingHelper.Backend.Models;

namespace PoeTradingHelper.Backend.Helper
{
    public class DataUpdater
    {
        public DataUpdater()
        {
            Context = new TradingContext();
            PoeNinjaApi = new PoeNinjaApi();
        }

        private PoeNinjaApi PoeNinjaApi { get; }
        private TradingContext Context { get; }

        public void UpdateAllData()
        {
          
            UpdateCurrencyTypes();
            UpdateDivinationCards();
            UpdateWeapons();
            UpdateArmours();
            UpdateFlasks();
            UpdateProphecies();
            UpdateCraftingBases();
            UpdateAccessories();
        }


        private void UpdateCurrencyTypes()
        {
            var currencies = PoeNinjaApi.GetCurrencies();

            foreach (var currency in currencies)
            {
                var dbCurrency = Context.Currencies.SingleOrDefault(c => c.PoeNinjaId == currency.Id);
                if (dbCurrency == default(Currency))
                    Context.Currencies.Add(currency);
                else
                {
                    dbCurrency.PriceInChaos = currency.PriceInChaos;
                    dbCurrency.PriceInExalted = currency.PriceInExalted;
                }
            }

            Context.SaveChanges();
        }

        private void UpdateDivinationCards()
        {
            var divinationCards = PoeNinjaApi.GetDivinationCards();

            foreach (var divinationCard in divinationCards)
            {
                var dbDivinationCard = Context.DivinationCards.SingleOrDefault(d => d.InGameId == divinationCard.InGameId);
                if (dbDivinationCard == default(DivinationCard))
                    Context.DivinationCards.Add(divinationCard);
                else
                {
                    divinationCard.PriceInChaos = divinationCard.PriceInChaos;
                    divinationCard.PriceInExalted = divinationCard.PriceInExalted;
                }
            }

            Context.SaveChanges();
        }

        private void UpdateWeapons()
        {
            var weapons = PoeNinjaApi.GetWeapons();

            foreach (var weapon in weapons)
            {
                var dbDivinationCard = Context.Weapons.SingleOrDefault(d => d.InGameId == weapon.InGameId);
                if (dbDivinationCard == default(Weapon))
                    Context.Weapons.Add(weapon);
                else
                {
                    weapon.PriceInChaos = weapon.PriceInChaos;
                    weapon.PriceInExalted = weapon.PriceInExalted;
                }
            }

            Context.SaveChanges();
        }

        private void UpdateArmours()
        {
            var armours = PoeNinjaApi.GetArmours();

            foreach (var armour in armours)
            {
                var dbArmour = Context.Armours.SingleOrDefault(d => d.InGameId == armour.InGameId);
                if (dbArmour == default(Armour))
                    Context.Armours.Add(armour);
                else
                {
                    armour.PriceInChaos = armour.PriceInChaos;
                    armour.PriceInExalted = armour.PriceInExalted;
                }
            }

            Context.SaveChanges();
        }

        private void UpdateFlasks()
        {
            var flasks = PoeNinjaApi.GetFlasks();

            foreach (var flask in flasks)
            {
                var dbFlask = Context.Flasks.SingleOrDefault(f => f.InGameId == flask.InGameId);
                if (dbFlask == default(Flask))
                    Context.Flasks.Add(flask);
                else
                {
                    dbFlask.PriceInChaos = flask.PriceInChaos;
                    dbFlask.PriceInExalted = flask.PriceInExalted;
                }
            }

            Context.SaveChanges();
        }

        private void UpdateProphecies()
        {
            var prophecies = PoeNinjaApi.GetProphecies();

            foreach (var prophecy in prophecies)
            {
                var dbProphecy = Context.Prophecies.SingleOrDefault(p => p.InGameId == prophecy.InGameId);
                if (dbProphecy == default(Prophecy))
                    Context.Prophecies.Add(prophecy);
                else
                {
                    dbProphecy.PriceInChaos = prophecy.PriceInChaos;
                    dbProphecy.PriceInExalted = prophecy.PriceInExalted;
                }
            }

            Context.SaveChanges();
        }

        private void UpdateCraftingBases()
        {
            var craftingBases = PoeNinjaApi.GetCraftingBases();

            foreach (var craftingBase in craftingBases)
            {
                var dbCraftingBase = Context.CraftingBases.SingleOrDefault(c => c.InGameId == craftingBase.InGameId);
                if (dbCraftingBase == default(CraftingBase))
                    Context.CraftingBases.Add(craftingBase);
                else
                {
                    dbCraftingBase.PriceInChaos = craftingBase.PriceInChaos;
                    dbCraftingBase.PriceInExalted = craftingBase.PriceInExalted;
                }
            }

            Context.SaveChanges();
        }

        private void UpdateAccessories()
        {
            var accessories = PoeNinjaApi.GetAccessories();

            foreach (var accessory in accessories)
            {
                var dbAccesory = Context.Accessories.SingleOrDefault(a => a.InGameId == accessory.InGameId);
                if (dbAccesory == default(Accessory))
                    Context.Accessories.Add(accessory);
                else
                {
                    dbAccesory.PriceInChaos = accessory.PriceInChaos;
                    dbAccesory.PriceInExalted = accessory.PriceInExalted;
                }
            }

            Context.SaveChanges();
        }

    }
}