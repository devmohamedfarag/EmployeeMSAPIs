using AutoMapper;
using EmployeeMS.Application.Dtos;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using EmployeeMS.Shared.LocalizationResources;
using MediatR;

namespace EmployeeMS.Application.Features.Employees.Commands.UpdateEmployeeCommand
{
    public class UpdateEmployeeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
                                                        : IRequestHandler<UpdateEmployeeCommand, EmployeeDto>
    {
        public async Task<EmployeeDto> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await unitOfWork.Employees.GetByIdAsync(request.Id);

            if (employee == null)
                throw new KeyNotFoundException(Resource.EmployeeNotFound);

            mapper.Map(request, employee);

            await unitOfWork.Employees.Update(employee);
            await unitOfWork.Compelete();

            return mapper.Map<EmployeeDto>(employee);
        }
    }
}
