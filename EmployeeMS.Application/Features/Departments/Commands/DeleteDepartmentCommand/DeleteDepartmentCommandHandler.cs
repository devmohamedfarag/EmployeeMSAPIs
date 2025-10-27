using AutoMapper;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using EmployeeMS.Shared.DTOs;
using EmployeeMS.Shared.LocalizationResources;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Commands.DeleteDepartmentCommand
{
    public class DeleteDepartmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
                                                 : IRequestHandler<DeleteDepartmentCommand, DeleteDto>
    {
        public async Task<DeleteDto> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await unitOfWork.Departments.GetByIdAsync(request.Id);

            if (department == null)
            {
                throw new KeyNotFoundException(Resource.DepartmentNotFound);
            }

            await unitOfWork.Departments.Delete(department);
            await unitOfWork.Compelete();

            return new DeleteDto { IsDeleted = true };
        }
    }
}
