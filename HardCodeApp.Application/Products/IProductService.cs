using HardCodeApp.Domain.Entities;
using HardCodeApp.Infrastructure.Dtos;

namespace HardCodeApp.Application.Products
{
    public interface IProductService
    {
        Task<ProductDto?> GetProductByIdAsync(int id);
        Task<IEnumerable<ProductDto>> GetProductsAsync();
        Task<int> CreateProductAsync(CreateProductDto createProductDto);
        Task<ProductDto?> UpdateProductAsync(int id, UpdateProductDto productDto);
        Task DeleteProductAsync(int id);
    }
}
