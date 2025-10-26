using AutoMapper;
using AutoMapper.QueryableExtensions;
using EmployeeMS.Application.Dtos;
using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.Repositories;
using EmployeeMS.Shared.Wrappers;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMS.Application.Features.Professions.Queries.GetAllProfessionsQuery
{
    public class GetAllProfessionsQueryHandler(IMapper mapper, IReadOnlyRepository<Profession> readonlyProfessionRepository)
                                               : IRequestHandler<GetAllProfessionsQuery, PagedData<ProfessionDto>>
    {
        public async Task<PagedData<ProfessionDto>> Handle(GetAllProfessionsQuery request, CancellationToken cancellationToken)
        {
            var query = readonlyProfessionRepository.GetAll();

            var professions = await query
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ProjectTo<ProfessionDto>(mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            var totalCount = await query.CountAsync(cancellationToken);

            return new PagedData<ProfessionDto>
            (
                professions,
                request.PageNumber,
                request.PageSize,
                totalCount
            );
        }
    }

}

