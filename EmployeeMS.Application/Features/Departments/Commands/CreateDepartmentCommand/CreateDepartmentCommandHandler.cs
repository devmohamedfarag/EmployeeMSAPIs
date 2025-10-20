using AutoMapper;
using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand
{
    // using primary constructor
    public class CreateDepartmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<CreateDepartmentCommand, int>
    {
        /*
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CreateDepartmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }*/

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
