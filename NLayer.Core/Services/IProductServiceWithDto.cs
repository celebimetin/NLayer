using NLayer.Core.Dtos;
using NLayer.Core.Models;

namespace NLayer.Core.Services
{
    public interface IProductServiceWithDto : IServiceWithDto<Product,  ProductDto>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategoryAsync();
        Task<CustomResponseDto<ProductDto>> AddAsync(ProductCreateDto dto);
        Task<CustomResponseDto<NoContentDto>> UpdateAsync(ProductUpdateDto dto);       
    }
}