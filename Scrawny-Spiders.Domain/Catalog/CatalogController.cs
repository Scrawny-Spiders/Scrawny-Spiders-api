using Microsoft.AspNetCore.Mvc;
using Scrawny.Spider.Domain.Catalog;


namespace Scrawny.Spider.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("hello world.");
        }
    }
}