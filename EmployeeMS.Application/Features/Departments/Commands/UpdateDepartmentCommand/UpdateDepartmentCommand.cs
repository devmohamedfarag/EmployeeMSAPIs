using EmployeeMS.Application.Dtos;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Commands.UpdateDepartmentCommand
{
    public record UpdateDepartmentCommand(int Id, string Name, string Description, DateTime CreationDate)


                                                                 : IRequest<DepartmentDto>;
}
