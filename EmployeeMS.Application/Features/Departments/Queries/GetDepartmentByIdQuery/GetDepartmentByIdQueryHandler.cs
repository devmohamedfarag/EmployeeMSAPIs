using AutoMapper;
using EmployeeMS.Application.Dtos.DepartmentDtos;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using EmployeeMS.Shared.LocalizationResources;
using MediatR;

namespace EmployeeMS.Application.Features.Departments.Queries.GetDepartmentByIdQuery
{
    public class GetDepartmentByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
                            : IRequestHandler<GetDepartmentByIdQuery, DepartmentDto>
    {
        public async Task<DepartmentDto> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var deparment = await unitOfWork.Departments.GetByIdAsync(request.Id);

            if (deparment == null)
            {
                throw new KeyNotFoundException(Resource.DepartmentNotFound);
            }

            return mapper.Map<DepartmentDto>(deparment);
        }
    }
}
