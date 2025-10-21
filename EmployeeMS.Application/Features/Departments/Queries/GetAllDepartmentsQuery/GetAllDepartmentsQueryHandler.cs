using AutoMapper;
using EmployeeMS.Application.Dtos.DepartmentDtos;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMS.Application.Features.Departments.Queries.GetAllDepartmentsQuery
{
    public class GetAllDepartmentsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
                                        : IRequestHandler<GetAllDepartmentsQuery, List<DepartmentDto>>
    {
        public async Task<List<DepartmentDto>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
        {
            var query = await unitOfWork.Departments.GetAllAsync();
           
            var departments = await query
                .OrderBy(d => d.Id)
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            return mapper.Map<List<DepartmentDto>>(departments);
        }
    }
}
