using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Dtos;
using NLayer.Core.Models;
using NLayer.Core.Services;
using NLayer.WebAPI.Filters;

namespace NLayer.WebAPI.Controllers
{
    public class ProductWithDtosController : CustomBaseController
    {
        private readonly IProductServiceWithDto _productServiceWithDto;

        public ProductWithDtosController(IProductServiceWithDto productServiceWithDto)
        {
            _productServiceWithDto = productServiceWithDto;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductsWithCategory()
        {
            return CreateActionResult(await _productServiceWithDto.GetProductsWithCategoryAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return CreateActionResult(await _productServiceWithDto.GetAllAsync());
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(NotFoundFilter<Product>))]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _productServiceWithDto.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductCreateDto productCreateDto)
        {
            return CreateActionResult(await _productServiceWithDto.AddAsync(productCreateDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductUpdateDto productUpdateDto)
        {
            return CreateActionResult(await _productServiceWithDto.UpdateAsync(productUpdateDto));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            return CreateActionResult(await _productServiceWithDto.RemoveAsync(id));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SaveAll(List<ProductDto> productDtos)
        {
            return CreateActionResult(await _productServiceWithDto.AddRangeAsync(productDtos));
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveAll(List<int> ids)
        {
            return CreateActionResult(await _productServiceWithDto.RemoveRangeAsync(ids));
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Any(int id)
        {
            return CreateActionResult(await _productServiceWithDto.AnyAsync(X=> X.Id == id));
        }
    }
}