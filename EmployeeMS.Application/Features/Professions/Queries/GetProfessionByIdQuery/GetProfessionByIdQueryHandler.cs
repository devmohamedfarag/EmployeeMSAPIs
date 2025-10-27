using AutoMapper;
using EmployeeMS.Application.Dtos;
using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.Repositories;
using EmployeeMS.Shared.LocalizationResources;
using MediatR;

namespace EmployeeMS.Application.Features.Professions.Queries.GetProfessionByIdQuery
{
    public class GetProfessionByIdQueryHandler(IReadOnlyRepository<Profession> readOnlyPrpfessionRepository, IMapper mapper) :
                                                      IRequestHandler<GetProfessionByIdQuery, ProfessionDto>
    {
        public async Task<ProfessionDto> Handle(GetProfessionByIdQuery request, CancellationToken cancellationToken)
        {
            var profession = await readOnlyPrpfessionRepository.GetAsync(p => p.Id == request.Id);

            if (profession == null)
            {
                throw new KeyNotFoundException(Resource.ProfessionNotFound);
            }

            return mapper.Map<ProfessionDto>(profession);
        }
    }
}
