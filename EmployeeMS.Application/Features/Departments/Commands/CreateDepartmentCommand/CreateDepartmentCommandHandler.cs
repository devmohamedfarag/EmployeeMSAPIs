using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand
{
    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateDepartmentCommandHandler(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = new Department
            {
              Name = request.Name,
              Description = request.Description,
            };

            await _unitOfWork.Departments.AddAsync(department);
            await _unitOfWork.Compelete();

            return department.Id;
        }
    }
}
