using EmployeeMS.Domain.Entities;
using EmployeeMS.Infrastructure.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMS.Infrastructure.Repositories
{
    public class ProfessionRepository : GenericRepository<Profession>
    {
        private readonly ApplicationDbContext _dbcontext;

        public ProfessionRepository(ApplicationDbContext dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
