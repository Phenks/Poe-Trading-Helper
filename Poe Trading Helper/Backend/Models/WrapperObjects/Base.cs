using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoeTradingHelper.Backend.Models.WrapperObjects
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
    }
}
