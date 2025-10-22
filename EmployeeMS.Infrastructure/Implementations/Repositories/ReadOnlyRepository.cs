using EmployeeMS.Domain.Interfaces.Repositories;
using EmployeeMS.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EmployeeMS.Infrastructure.Implementations.Repositories
{
    public class ReadOnlyRepository<TEntity>(ApplicationDbContext dbContext) : IReadOnlyRepository<TEntity> where TEntity : class
    {
        public IQueryable<TEntity> GetAll() 
            => dbContext
            .Set<TEntity>()
            .AsNoTracking()
            .AsQueryable();

        public async Task<TEntity>GetAsync(Expression<Func<TEntity, bool>> expression)
            =>await dbContext
            .Set<TEntity> ()
            .AsNoTracking ()
            .FirstOrDefaultAsync(expression);
    }
}
