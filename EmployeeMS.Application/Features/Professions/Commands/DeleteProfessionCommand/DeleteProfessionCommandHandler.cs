using AutoMapper;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using EmployeeMS.Shared.DTOs;
using EmployeeMS.Shared.LocalizationResources;
using MediatR;

namespace EmployeeMS.Application.Features.Professions.Commands.DeleteProfessionCommand
{
    public class DeleteProfessionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) 
                                                 : IRequestHandler<DeleteProfessionCommand, DeleteDto>
    {
        public async Task<DeleteDto> Handle(DeleteProfessionCommand request, CancellationToken cancellationToken)
        {
            var profession = await unitOfWork.Professions.GetByIdAsync(request.Id);

            if (profession == null)
            {
                throw new KeyNotFoundException(Resource.ProfessionNotFound);
            }

            await unitOfWork.Professions.Delete(profession);
            await unitOfWork.Compelete();

            return new DeleteDto { IsDeleted = true };
        }
    }
}
