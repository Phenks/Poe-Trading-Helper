using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoeTradingHelper.Backend.Models.WrapperObjects;

namespace PoeTradingHelper.Backend.Models
{
    public class ItemWithAmount : Base
    {
        public PoeObject Item { get; set; }
        public int Amount { get; set; }

        public float TotalValueInChaos
        {
            get => Item.PriceInChaos * Amount;
        }

        public float TotalValueInExalted
        {
            get => Item.PriceInExalted * Amount;

        }

    }
}
