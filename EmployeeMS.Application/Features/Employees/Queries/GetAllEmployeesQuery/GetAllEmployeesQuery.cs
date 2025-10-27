using EmployeeMS.Application.Dtos;
using EmployeeMS.Shared.Wrappers;
using MediatR;

namespace EmployeeMS.Application.Features.Employees.Queries.GetAllEmployeesQuery
{
    public record GetAllEmployeesQuery(int PageNumber = 1, int PageSize = 10) 
                                                            : IRequest<PagedData<EmployeeDto>>;
}
