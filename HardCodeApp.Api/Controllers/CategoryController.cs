using HardCodeApp.Domain.Entities;
using HardCodeApp.Infrastructure.Dtos;
using HardCodeApp.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HardCodeApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetCategories()
        {
            var categories = await _service.GetAllCategoriesAsync();
            return Ok(categories);
        }

        [HttpPost]
        public async Task<ActionResult<CategoryDto>> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var categoryId = await _service.CreateCategoryAsync(createCategoryDto);
            return CreatedAtAction(nameof(GetCategoryById), new { id = categoryId }, null);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> GetCategoryById(int id)
        {
            var category = await _service.GetCategoryByIdAsync(id);
            if (category is null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpGet("{id}/fields")]
        public async Task<ActionResult<IEnumerable<ProductFieldDto>>> GetProductFieldByCategoryId(int id)
        {
            var productFields = await _service.GetProductFieldByCategoryIdAsync(id);
            return Ok(productFields);
        }
    }
}
