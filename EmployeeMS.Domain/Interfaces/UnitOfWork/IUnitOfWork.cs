using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.Repositories;

namespace EmployeeMS.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEmployeeRepository Employees { get; }
        IGenericRepository<Department> Departments { get; }
        IGenericRepository<Profession> Professions { get; }

        Task<int> Compelete();
    }
}
