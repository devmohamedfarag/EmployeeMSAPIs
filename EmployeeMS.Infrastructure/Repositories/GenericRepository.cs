using EmployeeMS.Domain.Interfaces;
using EmployeeMS.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMS.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly ApplicationDbContext _dbcontext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _dbcontext = context;
            _dbSet = _dbcontext.Set<T>();
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            return await Task.FromResult(_dbSet.AsNoTracking().AsQueryable());
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbcontext.SaveChangesAsync();
            return entity;
        }

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
           await  _dbcontext.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _dbSet.Remove(entity);
            await _dbcontext.SaveChangesAsync();
        }

    }
}
