using System.Linq.Expressions;

namespace EmployeeMS.Domain.Interfaces.Repositories
{
    public interface IReadOnlyRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression);
    }
}
