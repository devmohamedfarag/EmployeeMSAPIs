using EmployeeMS.Domain.Entities;

namespace EmployeeMS.Domain.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetEmployeeByFirstNameAsync(string firstname);
    }
}
