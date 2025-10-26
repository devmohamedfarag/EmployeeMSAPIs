using MediatR;

namespace EmployeeMS.Application.Features.Employees.Commands.CreateEmployeeCommand
{
    public record CreateEmployeeCommand(string FirstName
                                       , string LastName
                                       , string Email
                                       , string PhoneNumber
                                       , double Salary
                                       , int DepartmentId
                                       , int ProfessionId) : IRequest<int>
    {
    }
}
