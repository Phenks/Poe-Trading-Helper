using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using PoeTradingHelper.Backend.DAL;
using PoeTradingHelper.Backend.Helper;
using PoeTradingHelper.Backend.Models;

namespace Tests
{
    [TestFixture]
    class DebugTests
    {

        [Test]
        public void RecreateAllData()
        {
            using (var Context = new TradingContext())
            {

                Context.Database.EnsureDeleted();
                Context.Database.EnsureCreated();
            }
            UpdateAllData();
            InitalizeCombinationResults();
        }

        [Test]
        public void CreateDataBase()
        {
            using (var Context = new TradingContext())
            {
                Context.Database.EnsureCreated();
            }
        }

        [Test]
        public void UpdateAllData()
        {
            DataUpdater updater = new DataUpdater();
            updater.UpdateAllData();
        }

        [Test]
        public void  InitalizeCombinationResults()
        {
            using (var Context = new TradingContext())
            {
                new CombinationResultsInitalizer().Initalize(Context);
            }
        }

        [Test]
        public void GetItemNameAndIdAsConstant()
        {
            using (var Context = new TradingContext())
            {
                var items =  Context.Currencies.Where(w => !w.IconUrl.Contains("relic=1"));

                string allIds = "";

                foreach (Currency item in items)
                {
                    allIds += $"public static int {item.Name.Replace(" ","_").Replace("'","").Replace("-","_").Replace("/","_")} = {item.PoeNinjaId};\n";

                }

                

            }
        }

        [Test]
        public void DBDataTest()
        {
            using (var Context = new TradingContext())
            {
                
                var combination = Context.CombinationResults.
                    Include(c => c.Ingredients).
                        ThenInclude(i => i.Item).
                    Include(c => c.Result)
                        .ThenInclude(i => i.Item)
                    .First();
                var profitPerTrade = combination.ProfitPerTradeInChaos;
            }
        }

        
    }
}
