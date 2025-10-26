using AutoMapper;
using EmployeeMS.Application.Dtos;
using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.Repositories;
using EmployeeMS.Shared.LocalizationResources;
using MediatR;

namespace EmployeeMS.Application.Features.Employees.Queries.GetEmployeeByIdQuery
{
    public class GetEmployeeByIdQueryHandler(IReadOnlyRepository<Employee> readOnlyEmployeeRepository, IMapper mapper)
                   : IRequestHandler<GetEmployeeByIdQuery, EmployeeDto>
    {
        public async Task<EmployeeDto> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employee = await readOnlyEmployeeRepository.GetAsync(e => e.Id == request.Id);

            if (employee == null)
            {
                throw new KeyNotFoundException(Resource.EmployeeNotFound);
            }

            return mapper.Map<EmployeeDto>(employee);
        }
    }
}
