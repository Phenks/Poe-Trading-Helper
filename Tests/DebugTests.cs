using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using PoeTradingHelper.Backend.DAL;
using PoeTradingHelper.Backend.DAL.Initializer;
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
            DataUpdater updater = new DataUpdater();
            updater.UpdateAllData();
            using (var Context = new TradingContext())
            {
                new CombinationResultsInitalizer().Initalize(Context);
            }


        }
        

        private void UpdateAllData()
        {
            DataUpdater updater = new DataUpdater();
            updater.UpdateAllData();
        }

        [Test]
        public void  RecreateCombinationResults()
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
                var items =  Context.UniqueMaps.Where(w => !w.IconUrl.Contains("relic=1"));

                string allIds = "";

                foreach (UniqueMap item in items)
                {
                    allIds += $"public static int {item.Name.Replace(" ","_").Replace("'","").Replace("-","_").Replace("/","_")} = {item.InGameId};\n";

                }

                

            }
        }

        [Test]
        public void DBDataTest()
        {
            using (var Context = new TradingContext())
            {
                
                var combination = Context.ItemCombinationsWithFixedResults.
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
