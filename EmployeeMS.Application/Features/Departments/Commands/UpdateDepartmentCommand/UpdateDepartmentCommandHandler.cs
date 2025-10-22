using AutoMapper;
using EmployeeMS.Application.Dtos.DepartmentDtos;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using EmployeeMS.Shared.LocalizationResources;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Commands.UpdateDepartmentCommand
{
    public class UpdateDepartmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
                                  : IRequestHandler<UpdateDepartmentCommand, DepartmentDto>
    {
        public async Task<DepartmentDto> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await unitOfWork.Departments.GetByIdAsync(request.Id);

            if (department == null)
                throw new KeyNotFoundException(Resource.DepartmentNotFound);

            mapper.Map(request, department);

            await unitOfWork.Departments.Update(department);
            await unitOfWork.Compelete();

            return mapper.Map<DepartmentDto>(department);
        }
    }
}

