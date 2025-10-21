using EmployeeMS.Application.Dtos.DepartmentDtos;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Commands.UpdateDepartmentCommand
{
    public record UpdateDepartmentCommand(int Id, string Name, string Description)
                                                                 : IRequest<DepartmentDto>
    {
    }
}
