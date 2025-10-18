using MediatR;

namespace EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand
{
    public class CreateDepartmentCommand : IRequest<int>
    {
        public string Name {  get; set; }
        public string Description { get; set; }
    }
}
