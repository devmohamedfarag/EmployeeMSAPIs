using AutoMapper;
using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand
{
    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CreateDepartmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) 
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = _mapper.Map<Department>(request);

            department.CreationDate = DateTime.UtcNow;

            await _unitOfWork.Departments.AddAsync(department);
            await _unitOfWork.Compelete();

            return department.Id;
        }
    }
}
