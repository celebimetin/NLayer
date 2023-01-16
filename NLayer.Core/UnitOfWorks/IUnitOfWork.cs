namespace NLayer.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task Commit();
        Task CommitAsync();
    }
}