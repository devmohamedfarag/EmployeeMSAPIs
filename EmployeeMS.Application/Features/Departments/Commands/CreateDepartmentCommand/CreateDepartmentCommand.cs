using MediatR;

namespace EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand
{
    public record CreateDepartmentCommand(string Name, string Description, DateTime CreationDate)
                                                                                        : IRequest<int>;
}
