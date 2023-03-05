using HardCodeApp.Domain.Entities;
using HardCodeApp.Infrastructure.Dtos;

namespace HardCodeApp.Infrastructure.Repositories
{
    public interface IProductFieldRespository
    {
        Task<ProductField> GetProductFieldByIdAsync(int id);
        Task AddProductFieldAsync(List<CreateProductFieldDto> productFields, int categoryId);
        Task<IEnumerable<ProductField>> GetProductFieldsByCategoryIdAsync(int categoryId);
    }
}
