using System.Linq;
using PoeTradingHelper.Backend.DAL;
using PoeTradingHelper.Backend.DAL.Initializer;
using PoeTradingHelper.Backend.Models;

namespace PoeTradingHelper.Backend.Helper
{
    public class DatabaseHelper
    {
        public static PoeObject GetItemById(int ingameItemId, TradingContext context)
        {
            try
            {
                return context.Items.First(item => item.InGameId == ingameItemId);
            }
            // If the item doesnt exist in the league yet
            catch
            {
                return GetMissingItem(context);
            }
        }

        public static PoeObject GetSkillgem(string nameConstant, int gemLevel, int quality, bool corrupted,
            TradingContext context)
        {
            try
            {
                PoeObject skillGem = context.Gems.First(gem => gem.Name == nameConstant &&
                                                               gem.Level == gemLevel &&
                                                               gem.Quality == quality &&
                                                               gem.Corrupted == corrupted);
                return skillGem;
            }
            catch
            {
                return GetMissingItem(context);
            }
        }

        public static PoeObject GetSkillgem(string nameConstant, int gemLevel, bool corrupted, TradingContext context)
        {
            try
            {
                PoeObject skillGem = context.Gems.First(gem => gem.Name == nameConstant &&
                                                               gem.Level == gemLevel &&
                                                               gem.Corrupted == corrupted);
                return skillGem;
            }
            catch
            {
                return GetMissingItem(context);
            }
        }

        private static PoeObject GetMissingItem(TradingContext context)
        {
            return GetItemById(ItemIds.Missing_Item, context);
        }
    }
}