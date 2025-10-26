using EmployeeMS.Application.Dtos;
using EmployeeMS.Shared.Wrappers;
using MediatR;

namespace EmployeeMS.Application.Features.Professions.Queries.GetAllProfessionsQuery
{
    public record GetAllProfessionsQuery(int PageNumber = 1, int PageSize = 10)
                                                : IRequest<PagedData<ProfessionDto>>
    {
    }
}
