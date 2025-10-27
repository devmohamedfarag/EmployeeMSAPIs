using EmployeeMS.Application.Dtos;
using MediatR;

namespace EmployeeMS.Application.Features.Employees.Commands.UpdateEmployeeCommand
{
    public record UpdateEmployeeCommand(int Id
                                        , string FirstName
                                        , string LastName
                                        , string Email
                                        , string PhoneNumber
                                        , double Salary
                                        , DateTime JoinDate
                                        , int DepartmentId
                                        , int ProfessionId) : IRequest<EmployeeDto>;
}
