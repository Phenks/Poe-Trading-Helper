using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PoeTradingHelper.Backend.DAL;
using PoeTradingHelper.Backend.DAL.Initializer;
using PoeTradingHelper.Backend.Helper;
using PoeTradingHelper.Backend.Models.ItemMapping;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PoeTradingHelper.Backend.Controllers
{
    [Route("api/[controller]")]
    public class ItemCombinations : Controller
    {
        
        //GET: api/<controller>
        [HttpGet("[action]")]
        public ICollection<ItemCombinationWithFixedResult> FixedResults(string combinationType = null)
        {

            using (TradingContext tradingContext = new TradingContext())
            {
                var itemCombinationWithFixedResults =  tradingContext
                    .ItemCombinationsWithFixedResults
                    .Include(c => c.Ingredients)
                    .ThenInclude(i => i.Item)
                    .Include(c => c.Result)
                    .ThenInclude(i => i.Item).ToList();
                if (combinationType != null)
                    itemCombinationWithFixedResults = itemCombinationWithFixedResults
                        .Where(ic => ic.CombinationType == combinationType).ToList();
                   
                return itemCombinationWithFixedResults;
            }
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}