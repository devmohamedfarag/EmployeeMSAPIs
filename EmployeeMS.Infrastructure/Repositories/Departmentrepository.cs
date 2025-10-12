using EmployeeMS.Domain.Entities;
using EmployeeMS.Infrastructure.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMS.Infrastructure.Repositories
{
    public class Departmentrepository : GenericRepository<Department>
    {
        private readonly ApplicationDbContext _dbcontext;

        public Departmentrepository(ApplicationDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
