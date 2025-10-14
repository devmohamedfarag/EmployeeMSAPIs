using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.Repositories;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using EmployeeMS.Infrastructure.AppDbContext;

namespace EmployeeMS.Infrastructure.Implementations.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbcontext;

        public IEmployeeRepository Employees { get; }
        public IGenericRepository<Department> Departments { get; }
        public IGenericRepository<Profession> Professions { get; }


        public UnitOfWork(
            ApplicationDbContext dbcontext, IEmployeeRepository employeeRepository,
            IGenericRepository<Department> departmentRepository, IGenericRepository<Profession> professionRepository)
        {
            _dbcontext = dbcontext;
            Employees = employeeRepository;
            Departments = departmentRepository;
            Professions = professionRepository;

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
