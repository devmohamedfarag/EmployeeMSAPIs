using AutoMapper;
using EmployeeMS.Application.Dtos.DepartmentDtos;
using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.Repositories;
using EmployeeMS.Shared.LocalizationResources;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Queries.GetDepartmentByIdQuery
{
    public class GetDepartmentByIdQueryHandler(IReadOnlyRepository<Department> readOnlyDeapartmentRepository, IMapper mapper)
                            : IRequestHandler<GetDepartmentByIdQuery, DepartmentDto>
    {
        public async Task<DepartmentDto> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var deparment = await readOnlyDeapartmentRepository.GetAsync(d => d.Id == request.Id);

            if (deparment == null)
            {
                throw new KeyNotFoundException(Resource.DepartmentNotFound);
            }

            return mapper.Map<DepartmentDto>(deparment);
        }
    }
}
