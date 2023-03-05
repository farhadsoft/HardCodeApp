using HardCodeApp.Application.Products;
using HardCodeApp.Infrastructure.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace HardCodeApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult<CreateProductDto>> CreateProduct([FromBody] CreateProductDto createProductDto)
        {
            var productId = await _service.CreateProductAsync(createProductDto);
            return CreatedAtAction(nameof(GetProductById), new { id = productId }, null);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProductById(int id)
        {
            var product = await _service.GetProductByIdAsync(id);
            return product is null ? NotFound() : Ok(product);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts()
        {
            var products = await _service.GetProductsAsync();
            return Ok(products);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] UpdateProductDto productDto)
        {
            var response = await _service.UpdateProductAsync(id, productDto);
            return response is null ? NotFound() : Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _service.DeleteProductAsync(id);
            return NoContent();
        }
    }
}
