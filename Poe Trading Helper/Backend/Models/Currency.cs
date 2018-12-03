using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using PoeTradingHelper.Backend.Helper.JsonWrappers;

namespace PoeTradingHelper.Backend.Models
{
    public class Currency : PoeObject
    {

        public int PoeNinjaId { get; set; }
        public int PoeTradeId { get; set; }
    }
}