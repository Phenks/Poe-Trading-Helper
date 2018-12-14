using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using PoeTradingHelper.Backend.Models.ItemMapping;
using PoeTradingHelper.Backend.Models.WrapperObjects;

namespace PoeTradingHelper.Backend.Models
{
    public abstract class ItemCombination : Base
    {
        protected ItemCombination()
        {
            Ingredients = new List<ItemWithAmount>();
        }
        
        public List<ItemWithAmount> Ingredients { get; set; }
        

        public int RequiredTrades
        {
            get
            {
                int totalTrades = 0;
                foreach (ItemWithAmount itemWithAmount in Ingredients)
                {
                    totalTrades += itemWithAmount.Amount;
                }
                

                return totalTrades ;
            }

        }
        public string CombinationType { get; set; } 
        public float ProfitPerTradeInChaos { get; protected set; }
        public float TotalCostInChaos { get; protected set; }
        public float TotalCostInExalted { get; protected set; }
        public float ProfitInChaos { get; protected set; }
        public float ProfitInExalted { get; protected set; }
        public float TotalIngredientCost { get; private set; }

        public void UpdateCostAndProfit()
        {
            UpdateTotalCostInChaos();
            UpdateTotalCostInExalted();
            UpdateProfitInChaos();
            UpdateProfitInExalted();
            UpdateProfitPerTrade();
            UpdateIngredientCost();
        }

        private void UpdateIngredientCost()
        {
            TotalIngredientCost = TotalCostInChaos / RequiredTrades;
        }

        private void UpdateTotalCostInExalted()
        {
            TotalCostInExalted = Ingredients.Sum(i => i.TotalValueInExalted);
        }

        protected abstract void UpdateProfitPerTrade();
        protected abstract void UpdateProfitInChaos();
        protected abstract void UpdateProfitInExalted();


        private void UpdateTotalCostInChaos()
        {
            TotalCostInChaos =  Ingredients.Sum(i => i.TotalValueInChaos);
        }
    }

    public sealed class CombinationType
    {
        public static CombinationType DivinationCard { get; } = new CombinationType("divinationCardTurnIn");

        private string Name { get; set; }

        private CombinationType(string combinationType)
        {
            Name = combinationType;
        }

        private CombinationType()
        {
            
        }

        public static implicit operator string(CombinationType combinationType)
        {
            return combinationType.Name;
        }
    }
}
