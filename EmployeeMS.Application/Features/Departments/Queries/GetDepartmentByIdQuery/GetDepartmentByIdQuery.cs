using EmployeeMS.Application.Dtos.DepartmentDtos;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Queries.GetDepartmentByIdQuery
{
    public record GetDepartmentByIdQuery(int Id) : IRequest<DepartmentDto>
    {
    }
}
