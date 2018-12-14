using Microsoft.EntityFrameworkCore;
using PoeTradingHelper.Backend.Models;
using PoeTradingHelper.Backend.Models.ItemMapping;

namespace PoeTradingHelper.Backend.DAL
{
    public class TradingContext : DbContext
    {
        public const string Connection =
            @"Server=(localdb)\mssqllocaldb;Database=PoeTrading;Trusted_Connection=True;ConnectRetryCount=0";

        public DbSet<DivinationCard> DivinationCards { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Armour> Armours { get; set; }
        public DbSet<Accessory> Accessories { get; set; }
        public DbSet<Flask> Flasks { get; set; }
        public DbSet<CraftingBase> CraftingBases { get; set; }
        public DbSet<Prophecy> Prophecies { get; set; }
        public DbSet<PoeObject> PoeObjects { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<ItemCombination> ItemCombinations { get; set; }
        public DbSet<ItemWithAmount> ItemWithAmounts { get; set; }
        public DbSet<ItemCombinationWithFixedResult> ItemCombinationsWithFixedResults { get; set; }
        public DbSet<Gem> Gems { get; set; }
        public DbSet<UniqueMap> UniqueMaps { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection);
          
            
            
        }
    }
}