using EmployeeMS.Shared.DTOs;
using MediatR;

namespace EmployeeMS.Application.Features.Employees.Commands.DeleteEmployeeCommand
{
    public record DeleteEmployeeCommand(int Id) : IRequest<DeleteDto>;
}
