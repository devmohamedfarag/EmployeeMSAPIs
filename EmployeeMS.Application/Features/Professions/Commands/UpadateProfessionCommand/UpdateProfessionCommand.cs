using EmployeeMS.Application.Dtos;
using MediatR;

namespace EmployeeMS.Application.Features.Professions.Commands.UpadateProfessionCommand
{
    public record UpdateProfessionCommand(int Id, string Title, string Description, double AcceptedSalary) 
                                                                       : IRequest<ProfessionDto>
    {
    }
}
