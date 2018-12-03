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
using PoeTradingHelper.Backend.Helper;
using PoeTradingHelper.Backend.Models;

namespace Poe_Trading_Helper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            DataUpdater dataUpdater = new DataUpdater();
            dataUpdater.UpdateAllData();    
            


            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
