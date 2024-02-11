using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Serilog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> logger;

        public ProductController(ILogger<ProductController> logger)
        {
            this.logger = logger;
        }
        [HttpGet("/Product")]
        public IActionResult GetProduct(int id)
        {
            logger.LogInformation("Product {Id} Is Getting", id);
            return Ok(new
            {
                id = id,
                ProductName = $"product {id}"
            });
        }
    }
}
