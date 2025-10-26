using EmployeeMS.Application.Dtos;
using MediatR;

namespace EmployeeMS.Application.Features.Professions.Queries.GetProfessionByIdQuery
{
    public record GetProfessionByIdQuery (int Id) : IRequest<ProfessionDto>;
}
