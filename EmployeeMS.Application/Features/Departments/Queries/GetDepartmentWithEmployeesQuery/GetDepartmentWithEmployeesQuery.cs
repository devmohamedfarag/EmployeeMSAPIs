using EmployeeMS.Application.Dtos;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Queries.GetDepartmentWithEmployees
{
    public record GetDepartmentWithEmployeesQuery(int DepartmentId) 
                                                : IRequest<DepartmentWithEmployeesDto>;
}
