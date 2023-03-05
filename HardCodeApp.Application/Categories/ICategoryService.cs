using HardCodeApp.Domain.Entities;
using HardCodeApp.Infrastructure.Dtos;

namespace HardCodeApp.Infrastructure.Repositories
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
        Task<CategoryDto> GetCategoryByIdAsync(int id);
        Task<int> CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task<IEnumerable<ProductFieldDto>> GetProductFieldByCategoryIdAsync(int categoryId);
    }
}
