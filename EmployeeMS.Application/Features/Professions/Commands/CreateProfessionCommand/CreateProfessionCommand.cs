using MediatR;

namespace EmployeeMS.Application.Features.Professions.Commands.CreateProfessionCommand
{
    public record CreateProfessionCommand(string Title, string Description, double AcceptedSalary) 
                                                                                      : IRequest<int>
    {

    }
}
