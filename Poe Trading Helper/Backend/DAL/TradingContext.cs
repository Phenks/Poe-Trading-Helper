using Microsoft.EntityFrameworkCore;
using PoeTradingHelper.Backend.Models;

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
        public DbSet<ItemCombinationResult> CombinationResults { get; set; }
        public DbSet<ItemWithAmount> ItemWithAmounts { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection);
          
            
        }
    }
}