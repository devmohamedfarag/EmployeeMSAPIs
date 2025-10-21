using EmployeeMS.Application.Dtos.DepartmentDtos;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Queries.GetAllDepartmentsQuery
{
    public record GetAllDepartmentsQuery(int PageNumber = 1, int PageSize = 10)
                                   : IRequest<List<DepartmentDto>>
    {

    }
}
