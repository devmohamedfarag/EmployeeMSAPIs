using MediatR;

namespace EmployeeMS.Application.Features.Departments.Commands.DeleteDepartmentCommand
{
    public record DeleteDepartmentCommand(int Id) : IRequest<string>
    { 
    }
}
