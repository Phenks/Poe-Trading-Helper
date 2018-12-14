using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using PoeTradingHelper.Backend.Models.WrapperObjects;

namespace PoeTradingHelper.Backend.Models.ItemMapping
{
    public class ItemCombinationResult : Base
    {
        public ItemCombinationResult()
        {
            Amount = 1;
        }
        

        public PoeObject Item { get; set; }
        public bool Corrupted { get; set; }
        public int Amount { get; set; }
    }
}
