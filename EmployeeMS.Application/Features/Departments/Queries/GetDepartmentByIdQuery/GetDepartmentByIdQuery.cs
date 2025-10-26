using EmployeeMS.Application.Dtos;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Queries.GetDepartmentByIdQuery
{
    public record GetDepartmentByIdQuery(int Id) : IRequest<DepartmentDto>
    {
    }
}
