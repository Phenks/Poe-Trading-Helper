using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PoeTradingHelper.Backend.DAL;
using PoeTradingHelper.Backend.DAL.Initializer;
using PoeTradingHelper.Backend.Helper;
using PoeTradingHelper.Backend.Models;

namespace Poe_Trading_Helper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RecreateAllData();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static void RecreateAllData()
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

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
