using AutoMapper;
using EmployeeMS.Application.Dtos;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using EmployeeMS.Shared.LocalizationResources;
using MediatR;

namespace EmployeeMS.Application.Features.Professions.Commands.UpadateProfessionCommand
{
    public class UpdateProfessionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
                                                 : IRequestHandler<UpdateProfessionCommand, ProfessionDto>
    {
        public async Task<ProfessionDto> Handle(UpdateProfessionCommand request, CancellationToken cancellationToken)
        {
            var profession = await unitOfWork.Professions.GetByIdAsync(request.Id);

            if (profession == null)
            {
                throw new KeyNotFoundException(Resource.ProfessionNotFound);
            }

            mapper.Map(request, profession);

            await unitOfWork.Professions.Update(profession);
            await unitOfWork.Compelete();

            return mapper.Map<ProfessionDto>(profession);
        }
    }
}

