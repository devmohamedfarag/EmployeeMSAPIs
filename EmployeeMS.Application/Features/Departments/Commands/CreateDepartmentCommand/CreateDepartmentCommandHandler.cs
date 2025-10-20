using AutoMapper;
using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand
{
    public class CreateDepartmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<CreateDepartmentCommand, int>
    {
        public async Task<int> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = mapper.Map<Department>(request);

            department.CreationDate = DateTime.UtcNow;

            await unitOfWork.Departments.AddAsync(department);
            await unitOfWork.Compelete();

            return department.Id;
        }
    }
}
