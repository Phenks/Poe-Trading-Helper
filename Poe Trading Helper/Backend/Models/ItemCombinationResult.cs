using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using PoeTradingHelper.Backend.Models.WrapperObjects;

namespace PoeTradingHelper.Backend.Models
{
    public class ItemCombinationResult : Base
    {
        
        public List<ItemWithAmount> Ingredients { get; set; }
        public ItemWithAmount Result { get; set; }

        public int RequiredTrades
        {
            get
            {
                int totalTrades = 0;
                foreach (ItemWithAmount itemWithAmount in Ingredients)
                {
                    totalTrades += itemWithAmount.Amount;
                }
                totalTrades += 1;

                return totalTrades ;
            }

        }

        public float ProfitPerTradeInChaos
        {
            get
            {
                float Profit = Result.TotalValueInChaos - TotalCostInChaos;
                return Profit / RequiredTrades;
            }
        }

        public float TotalCostInChaos
        {
            get
            {
                return Ingredients.Sum(i => i.TotalValueInChaos);
            }
        }

    }
}
