using NLayer.Core.Dtos;

namespace NLayer.WebApp.Services
{
    public class CategoryApiService
    {
        private readonly HttpClient _httpClient;

        public CategoryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CategoryDto>> GetAllAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<CategoryDto>>>("categories");
            return response.Data;
        }
        public async Task<CategoryWithProductsDto> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<CategoryWithProductsDto>>($"categories/{categoryId}");
            return response.Data;
        }
    }
}