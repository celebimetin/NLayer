using NLayer.Core.Dtos;
using NLayer.Core.Models;

namespace NLayer.Core.Services
{
    public interface IProductService : IServices<Product>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategoryAsync();
    }
}