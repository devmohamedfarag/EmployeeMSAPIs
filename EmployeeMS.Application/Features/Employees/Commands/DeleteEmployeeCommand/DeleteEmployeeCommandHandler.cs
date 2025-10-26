using AutoMapper;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using EmployeeMS.Shared.DTOs;
using EmployeeMS.Shared.LocalizationResources;
using MediatR;

namespace EmployeeMS.Application.Features.Employees.Commands.DeleteEmployeeCommand
{
    public class DeleteEmployeeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
                                  : IRequestHandler<DeleteEmployeeCommand, DeleteDto>
    {
        public async Task<DeleteDto> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await unitOfWork.Employees.GetByIdAsync(request.Id);

            if (employee == null)
            {
                throw new KeyNotFoundException(Resource.EmployeeNotFound);
            }

            await unitOfWork.Employees.Delete(employee);
            await unitOfWork.Compelete();

            return new DeleteDto {IsDeleted = true};
        }
    }
}
