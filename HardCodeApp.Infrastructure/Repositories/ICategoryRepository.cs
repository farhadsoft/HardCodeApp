using HardCodeApp.Domain.Entities;

namespace HardCodeApp.Infrastructure.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetCategoriesAsync();
        Task<Category> GetCategoryByIdAsync(int id);
        Task<int> AddCategoryAsync(Category category);
    }
}
