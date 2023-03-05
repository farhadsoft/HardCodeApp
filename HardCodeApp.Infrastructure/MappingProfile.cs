using AutoMapper;
using HardCodeApp.Domain.Entities;
using HardCodeApp.Infrastructure.Dtos;

namespace HardCodeApp.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<CreateCategoryDto, Category>();

            CreateMap<ProductField, ProductFieldDto>().ReverseMap();
            CreateMap<CreateProductFieldDto, ProductField>();
        }
    }
}
