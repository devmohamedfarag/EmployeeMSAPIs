using AutoMapper;
using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using MediatR;

namespace EmployeeMS.Application.Features.Employees.Commands.CreateEmployeeCommand
{
    public class CreateEmployeeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
                                                               : IRequestHandler<CreateEmployeeCommand, int>
    {
        public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = mapper.Map<Employee>(request);

            employee.JoinDate = DateTime.UtcNow;

            await unitOfWork.Employees.AddAsync(employee);
            await unitOfWork.Compelete();

            return employee.Id;

        }
    }
}
