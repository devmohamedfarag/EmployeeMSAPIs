using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.Repositories;
using EmployeeMS.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMS.Infrastructure.Implementations.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbcontext;

        public EmployeeRepository(ApplicationDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IEnumerable<Employee>> GetEmployeeByFirstNameAsync(string firstname)
        {
            return await _dbcontext.Employees
                                         .Where(e => e.FirstName == firstname)
                                         .ToListAsync();
        }
    }
}
