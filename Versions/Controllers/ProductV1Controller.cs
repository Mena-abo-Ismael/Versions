using Microsoft.AspNetCore.Mvc;
using Versions.Model;

namespace Versions.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/Products")]
    public class ProductV1Controller : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var data = new ProductV1
            {
                ID = 1,
                Name="Laptop",
                Price=25000
            };
            return Ok(data);
        }
    }
}
