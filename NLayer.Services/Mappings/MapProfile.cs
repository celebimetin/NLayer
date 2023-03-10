using AutoMapper;
using NLayer.Core.Dtos;
using NLayer.Core.Models;

namespace NLayer.Services.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Product, ProductWithCategoryDto>();
            CreateMap<ProductCreateDto, Product>();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Category, CategoryWithProductsDto>();
        }
    }
}