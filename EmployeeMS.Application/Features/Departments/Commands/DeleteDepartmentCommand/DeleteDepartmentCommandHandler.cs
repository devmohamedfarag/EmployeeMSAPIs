using AutoMapper;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using EmployeeMS.Shared.LocalizationResources;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Commands.DeleteDepartmentCommand
{
    public class DeleteDepartmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
                                                 : IRequestHandler<DeleteDepartmentCommand, string>
    {
        public async Task<string> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await unitOfWork.Departments.GetByIdAsync(request.Id);

            if (department == null)
            {
                throw new KeyNotFoundException(Resource.DepartmentNotFound);
            }

            await unitOfWork.Departments.Delete(department);
            await unitOfWork.Compelete();

            return Resource.DepartmentDeleted;
        }

    }
}
