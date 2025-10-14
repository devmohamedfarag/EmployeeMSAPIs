using EmployeeMS.Domain.Entities;

namespace EmployeeMS.Domain.Interfaces.Repositories
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetEmployeeByFirstNameAsync(string firstname);
    }
}
