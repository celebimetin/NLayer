using NLayer.Core.Dtos;
using NLayer.Core.Models;
using System.Linq.Expressions;

namespace NLayer.Core.Services
{
    public interface IServiceWithDto<TEntity, TDto> where TEntity : BaseEntity where TDto : class
    {
        Task<CustomResponseDto<TDto>> GetByIdAsync(int id);
        Task<CustomResponseDto<IEnumerable<TDto>>> GetAllAsync();
        Task<CustomResponseDto<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> expression);
        Task<CustomResponseDto<bool>> AnyAsync(Expression<Func<TEntity, bool>> expression);
        Task<CustomResponseDto<TDto>> AddAsync(TDto dto);
        Task<CustomResponseDto<IEnumerable<TDto>>> AddRangeAsync(IEnumerable<TDto> dtos);
        Task<CustomResponseDto<NoContentDto>> UpdateAsync(TDto dto);
        Task<CustomResponseDto<NoContentDto>> RemoveAsync(int id);
        Task<CustomResponseDto<NoContentDto>> RemoveRangeAsync(IEnumerable<int> ids);
    }
}