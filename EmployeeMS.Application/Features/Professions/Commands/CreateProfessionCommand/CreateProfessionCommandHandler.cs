using AutoMapper;
using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using MediatR;

namespace EmployeeMS.Application.Features.Professions.Commands.CreateProfessionCommand
{
    public class CreateProfessionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
                                                : IRequestHandler<CreateProfessionCommand, int>
    {
        public async Task<int> Handle(CreateProfessionCommand request, CancellationToken cancellationToken)
        {
            var profession = mapper.Map<Profession>(request);

            await unitOfWork.Professions.AddAsync(profession);

            await unitOfWork.Compelete();

            return profession.Id;
        }

    }
}
