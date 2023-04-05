using Microsoft.AspNetCore.Mvc;
using Scrawny.Spider.Domain.Catalog;
using Scrawny.Spider.Data;




namespace Scrawny.Spider.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly StoreContext _db;

        public CatalogController(StoreContext db) {
            _db = db;
        }
        

        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new List<Item>() {
                new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
                new Item("Shorts", "Ohio State shorts.", "Nike", 44.99m)
            };

            return Ok("hello world.");
        }
        [HttpGet("{id:int}")]
        public IActionResult GetItem()
        {
            return Ok(_db.Items);

        }
        [HttpPost]
        public IActionResult Post(Item item)
        {
            return Created("/catalog/42", item);
        }
        [HttpPost("{id:int}/ratings")]
        public IActionResult PostRating(int id, [FromBody] Rating rating) 
        {
            var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
            item.Id = id;
            item.AddRating(rating);

            return Ok(item);
        }
        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Item item) 
        {
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }

}