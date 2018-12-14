using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoeTradingHelper.Backend.Models.ItemMapping
{
    public class ItemCombinationWithFixedResult : ItemCombination
    {
        public ItemCombinationWithFixedResult(): base()
        {
        }

        public ItemCombinationWithFixedResult(List<ItemWithAmount> ingredients,ItemCombinationResult result) :this()
        {
            Ingredients = ingredients;
            Result = result;
        }

        public ItemCombinationResult Result { get; set; }

        protected override void UpdateProfitPerTrade()
        {
            
            ProfitPerTradeInChaos = ProfitInChaos / RequiredTrades;
        }

        protected override void UpdateProfitInChaos()
        {
            ProfitInChaos = Result.Item.PriceInChaos * Result.Amount - TotalCostInChaos;
        }

        protected override void UpdateProfitInExalted()
        {
            ProfitInExalted = Result.Item.PriceInExalted * Result.Amount - TotalCostInExalted;
        }
    }
}
