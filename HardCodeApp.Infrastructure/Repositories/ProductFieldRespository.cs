using AutoMapper;
using HardCodeApp.Domain.Entities;
using HardCodeApp.Infrastructure.Dtos;
using Microsoft.EntityFrameworkCore;

namespace HardCodeApp.Infrastructure.Repositories
{
    public class ProductFieldRespository : IProductFieldRespository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProductFieldRespository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddProductFieldAsync(List<CreateProductFieldDto> productFieldsDto, int categoryId)
        {
            var productFields = _mapper.Map<List<ProductField>>(productFieldsDto);

            foreach (var productField in productFields)
            {
                productField.CategoryId = categoryId;
                await _context.ProductFields.AddAsync(productField);
            }
        }

        public async Task<ProductField> GetProductFieldByIdAsync(int id)
        {
            return await _context.ProductFields.FirstAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<ProductField>> GetProductFieldsByCategoryIdAsync(int categoryId)
        {
            var query = _context.ProductFields.Where(p => p.CategoryId == categoryId)
                                              .AsQueryable();

            return await query.ToListAsync();
        }
    }
}
