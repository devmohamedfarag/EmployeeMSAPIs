using EmployeeMS.Domain.Entities;
using EmployeeMS.Infrastructure.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMS.Infrastructure.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
        private readonly ApplicationDbContext _dbcontext;

        public EmployeeRepository(ApplicationDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
