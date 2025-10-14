using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.Repositories;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using EmployeeMS.Infrastructure.AppDbContext;
using EmployeeMS.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMS.Infrastructure.UnitOfWorkImbl
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbcontext;

        public IEmployeeRepository Employees { get; private set; }
        public IGenericRepository<Department> Departments { get; private set; }
        public IGenericRepository<Profession> Professions { get; private set; }


        public UnitOfWork(ApplicationDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<int> Compelete()
        {
            return await _dbcontext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbcontext.Dispose();
        }
    }
}
