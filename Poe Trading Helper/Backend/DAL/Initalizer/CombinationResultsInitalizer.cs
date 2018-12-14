using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PoeTradingHelper.Backend.Models;
using PoeTradingHelper.Backend.Models.ItemMapping;

namespace PoeTradingHelper.Backend.DAL.Initializer
{
    public class CombinationResultsInitalizer
    {
        public static TradingContext Context;
        public void Initalize(TradingContext context)
        {
            Context = context;

            context.Items.Add(new Item() {InGameId = ItemIds.Missing_Item, IconUrl = "https://cdn0.iconfinder.com/data/icons/basic-ui-elements-colored/700/010_x-3-512.png" });

            context.SaveChanges();

            var allItemCombinationResults = new List<ItemCombinationWithFixedResult>
            {
                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.House_of_Mirrors).Times(9)
                }).WithTheCurrencyResult(CurrencyId.Mirror_of_Kalandra),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.Beauty_Through_Death).Times(9)
                }).WithTheItemResult(ItemIds.Prophecies.The_Queens_Sacrifice),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Doctor).Times(8)
                }).WithTheItemResult(ItemIds.Accessories.Headhunter),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Fiend).Times(11)
                }).WithTheItemResult(ItemIds.Accessories.Headhunter,corrupted: true),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.Immortal_Resolve).Times(6)
                }).WithTheItemResult(ItemIds.Prophecies.Fated_Connections),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Immortal).Times(10)
                }).WithTheItemResult(ItemIds.DivinationCards.House_of_Mirrors),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.Abandoned_Wealth).Times(6)
                }).WithTheCurrencyResult(CurrencyId.Exalted_Orb).ResultTimes(3),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Wolven_Kings_Bite).Times(8)
                }).WithTheItemResult(ItemIds.Armours.Rigwalds_Quills),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.Hunters_Reward).Times(3)
                }).WithTheItemResult(ItemIds.Accessories.The_Taming),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Nurse).Times(8)
                }).WithTheItemResult(ItemIds.DivinationCards.The_Doctor),
               

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Iron_Bard).Times(9)
                }).WithTheItemResult(ItemIds.Prophecies.Trash_to_Treasure),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Dragons_Heart).Times(11)
                }).WithTheSkillGemResult(SkillGemNames.Empower,4,true),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.A_Dab_Of_Ink).Times(9)
                }).WithTheItemResult(ItemIds.Weapons.The_Poets_Pen),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.Pride_Before_the_Fall).Times(8)
                }).WithTheItemResult(ItemIds.Armours.Kaoms_Heart,true),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Spark_and_the_Flame).Times(2)
                }).WithTheItemResult(ItemIds.Accessories.Bereks_Respite),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_World_Eater).Times(8)
                }).WithTheItemResult(ItemIds.Weapons.Starforge),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.Wealth_and_Power).Times(11)
                }).WithTheSkillGemResult(SkillGemNames.Enlighten,4,true),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Master).Times(4)
                }).WithTheItemResult(ItemIds.Accessories.Biscos_Collar),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Mayor).Times(5)
                }).WithTheItemResult(ItemIds.UniqueMaps.The_Perandus_Manor),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Wind).Times(7)
                }).WithTheItemResult(ItemIds.Weapons.Windripper),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Brittle_Emperor).Times(8)
                }).WithTheItemResult(ItemIds.Accessories.Volls_Devotion,true),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Kings_Heart).Times(8)
                }).WithTheItemResult(ItemIds.Armours.Kaoms_Heart),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Saints_Treasure).Times(10)
                }).WithTheCurrencyResult(CurrencyId.Exalted_Orb).ResultTimes(2),
               

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Last_One_Standing).Times(10)
                }).WithTheItemResult(ItemIds.Weapons.Atziris_Disfavour),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Offering).Times(8)
                }).WithTheItemResult(ItemIds.Armours.Shavronnes_Wrappings),

              

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Risk).Times(3)
                }).WithTheItemResult(ItemIds.Accessories.Ventors_Gamble),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Endless_Darkness).Times(9)
                }).WithTheItemResult(ItemIds.Weapons.Voidforge),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Queen).Times(16)
                }).WithTheItemResult(ItemIds.Armours.Atziris_Acuity),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Formless_Sea).Times(7)
                }).WithTheItemResult(ItemIds.Weapons.Varunastra),
                
                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Enlightened).Times(6)
                }).WithTheSkillGemResult(SkillGemNames.Enlighten,3,false),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Polymath).Times(3)
                }).WithTheItemResult(ItemIds.Accessories.Astramentis),

          
                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Hunger).Times(9)
                }).WithTheItemResult(ItemIds.Flasks.Taste_of_Hate),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Professor).Times(4)
                }).WithTheItemResult(ItemIds.UniqueMaps.The_Putrid_Cloister),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Hoarder).Times(12)
                }).WithTheCurrencyResult(CurrencyId.Exalted_Orb),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Hunger).Times(9)
                }).WithTheItemResult(ItemIds.Flasks.Taste_of_Hate),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Artist).Times(11)
                }).WithTheSkillGemResult(SkillGemNames.Enhance,4,true),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Valley_of_Steel_Boxes).Times(9)
                }).WithTheItemResult(ItemIds.Prophecies.Monstrous_Treasure),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Jewellers_Boon).Times(5)
                }).WithTheItemResult(ItemIds.Prophecies.The_Jewellers_Touch),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Throne).Times(2)
                }).WithTheItemResult(ItemIds.Armours.Kaoms_Roots,true),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                An.Ingredient.WithTheItem(ItemIds.DivinationCards.The_Wind).Times(7)
                }).WithTheItemResult(ItemIds.Weapons.Windripper),

                A.ItemCombinationWithAFixedResult.ThatUsesTheIngridients(new List<ItemWithAmount>
                {
                    An.Ingredient.WithTheItem(ItemIds.DivinationCards.Last_Hope).Times(3)
                }).WithTheItemResult(ItemIds.Armours.Kaoms_Roots,true),
            };
            foreach (ItemCombinationWithFixedResult itemCombination in allItemCombinationResults)
            {
                itemCombination.UpdateCostAndProfit();
            }

            Context.ItemCombinationsWithFixedResults.AddRange(allItemCombinationResults);
            Context.SaveChanges();
        }
    }


}