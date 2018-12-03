using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoeTradingHelper.Backend.Models;

namespace PoeTradingHelper.Backend.Helper
{
    public class CurrencyConverter
    {
        public static float CalculatePriceInExalted(PoeObject poeObject,float chaosPerExaltedOrb)
        {
            return poeObject.PriceInChaos / chaosPerExaltedOrb;
        }
    }
}
