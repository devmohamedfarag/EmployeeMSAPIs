using EmployeeMS.Shared.DTOs;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Commands.DeleteDepartmentCommand
{
    public record DeleteDepartmentCommand(int Id) : IRequest<DeleteDto>;
}
