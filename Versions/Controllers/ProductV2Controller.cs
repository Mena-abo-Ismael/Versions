using Microsoft.AspNetCore.Mvc;
using Versions.Model;

namespace Versions.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/Products")]
    public class ProductV2Controller : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var data = new ProductV2
            {
                Id = 1,
                Name="Laptop",
                Price=25000,
                CategoryName="Electronices"
            };
            return Ok(data);
        }
    }
}
