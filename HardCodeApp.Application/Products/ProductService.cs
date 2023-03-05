using AutoMapper;
using HardCodeApp.Domain.Entities;
using HardCodeApp.Infrastructure.Dtos;
using HardCodeApp.Infrastructure.Repositories;

namespace HardCodeApp.Application.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ProductDto?> GetProductByIdAsync(int id)
        {
            var product = await _repository.GetProductByIdAsync(id);
            if (product is null)
            {
                return null;
            }
            var response = _mapper.Map<ProductDto>(product);
            return response;
        }

        public async Task<IEnumerable<ProductDto>> GetProductsAsync()
        {
            var products = await _repository.GetProductsAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<int> CreateProductAsync(CreateProductDto createProductDto)
        {
            var product = _mapper.Map<Product>(createProductDto);
            await _repository.CreateProductAsync(product);
            return product.Id;
        }

        public async Task<ProductDto?> UpdateProductAsync(int productId, UpdateProductDto productDto)
        {
            var product = await _repository.GetProductByIdAsync(productId);
            if (product is null)
            {
                return null;
            }

            _mapper.Map(productDto, product);
            await _repository.UpdateProductAsync(product);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task DeleteProductAsync(int productId)
        {
            await _repository.DeleteProductAsync(productId);
        }
    }
}
