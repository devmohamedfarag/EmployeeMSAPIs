using EmployeeMS.Application.Dtos;
using MediatR;

namespace EmployeeMS.Application.Features.Employees.Queries.GetEmployeeByIdQuery
{
    public record GetEmployeeByIdQuery(int Id) : IRequest<EmployeeDto>;
}
