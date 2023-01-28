using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Dtos;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.WebAPI.Controllers
{
    public class CategoryWithDtosController : CustomBaseController
    {
        private readonly IServiceWithDto<Category, CategoryDto> _serviceWithDto;

        public CategoryWithDtosController(IServiceWithDto<Category, CategoryDto> serviceWithDto)
        {
            _serviceWithDto = serviceWithDto;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _serviceWithDto.GetAllAsync());
        }

        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetSingleCategory(int categoryId)
        {
            return CreateActionResult(await _serviceWithDto.GetByIdAsync(categoryId));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto categoryDto)
        {
            return CreateActionResult(await _serviceWithDto.AddAsync(categoryDto));
        }
    }
}