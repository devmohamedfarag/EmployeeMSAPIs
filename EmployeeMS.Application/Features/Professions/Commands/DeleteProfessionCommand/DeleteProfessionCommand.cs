using EmployeeMS.Shared.DTOs;
using MediatR;

namespace EmployeeMS.Application.Features.Professions.Commands.DeleteProfessionCommand
{
    public record DeleteProfessionCommand(int Id) : IRequest<DeleteDto>;
}
