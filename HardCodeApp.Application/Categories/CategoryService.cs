using AutoMapper;
using HardCodeApp.Domain.Entities;
using HardCodeApp.Infrastructure.Dtos;

namespace HardCodeApp.Infrastructure.Repositories
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductFieldRespository _productFieldRespository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository,
                               IProductFieldRespository productFieldRespository,
                               IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _productFieldRespository = productFieldRespository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync()
        {
            var categories = await _categoryRepository.GetCategoriesAsync();
            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }

        public async Task<CategoryDto> GetCategoryByIdAsync(int id)
        {
            var category = await _categoryRepository.GetCategoryByIdAsync(id);
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<int> CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var category = _mapper.Map<Category>(createCategoryDto);
            var categoryId = await _categoryRepository.AddCategoryAsync(category);
            await _productFieldRespository.AddProductFieldAsync(createCategoryDto.Fields, categoryId);
            return categoryId;
        }

        public async Task<IEnumerable<ProductFieldDto>> GetProductFieldByCategoryIdAsync(int categoryId)
        {
            var productFields = await _productFieldRespository.GetProductFieldsByCategoryIdAsync(categoryId);
            return _mapper.Map<IEnumerable<ProductFieldDto>>(productFields);
        }
    }
}
