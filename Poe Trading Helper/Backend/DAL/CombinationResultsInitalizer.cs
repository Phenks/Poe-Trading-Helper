using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PoeTradingHelper.Backend.Models;

namespace PoeTradingHelper.Backend.DAL
{
    public class CombinationResultsInitalizer
    {
        public static TradingContext Context;
        public void Initalize(TradingContext context)
        {
            Context = context;



            var allItemCombinationResults = new List<ItemCombinationResult>
            {
                A.ItemCombination.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(Items.DivinationCards.The_Last_One_Standing).Times(10)
                }).WithTheItemResult(Items.Weapons.Atziris_Disfavour),

                A.ItemCombination.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(Items.DivinationCards.The_Last_One_Standing).Times(10)
                }).WithTheItemResult(Items.Weapons.Atziris_Disfavour),
            };



            Context.CombinationResults.AddRange(allItemCombinationResults);
            Context.SaveChanges();
        }
    }


}