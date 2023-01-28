using NLayer.Core.Dtos;
using NLayer.Core.Models;

namespace NLayer.Core.Services
{
    public interface ICategoryService : IServices<Category>
    {
        Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}