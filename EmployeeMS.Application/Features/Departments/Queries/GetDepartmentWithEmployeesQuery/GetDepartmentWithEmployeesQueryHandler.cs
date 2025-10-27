using AutoMapper;
using EmployeeMS.Application.Dtos;
using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.Repositories;
using EmployeeMS.Shared.LocalizationResources;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMS.Application.Features.Departments.Queries.GetDepartmentWithEmployees
{
    public class GetDepartmentWithEmployeesQueryHandler(IReadOnlyRepository<Department> readOnlyRepository, IMapper mapper)
                                     : IRequestHandler<GetDepartmentWithEmployeesQuery, DepartmentWithEmployeesDto>
    {
        public async Task<DepartmentWithEmployeesDto> Handle(GetDepartmentWithEmployeesQuery request, CancellationToken cancellationToken)
        {
            var department = await readOnlyRepository
                .GetAll()
                .Include(d => d.Employees)
                .FirstOrDefaultAsync(d => d.Id == request.DepartmentId, cancellationToken);

            if (department == null)
            {
                throw new KeyNotFoundException(Resource.DepartmentNotFound);
            }

            var result = mapper.Map<DepartmentWithEmployeesDto>(department);

            return result;
        }
    }
}
