using AutoMapper;
using AutoMapper.QueryableExtensions;
using EmployeeMS.Application.Dtos;
using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.Repositories;
using EmployeeMS.Shared.Wrappers;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMS.Application.Features.Departments.Queries.GetAllDepartmentsQuery
{
    public class GetAllDepartmentsQueryHandler(IMapper mapper, IReadOnlyRepository<Department> readonlyDepartmantRepository)
                                               : IRequestHandler<GetAllDepartmentsQuery, PagedData<DepartmentDto>>
    {
        public async Task<PagedData<DepartmentDto>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
        {
            var query = readonlyDepartmantRepository.GetAll();

            var departments = await query
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ProjectTo<DepartmentDto>(mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            var totalCount = await query.CountAsync(cancellationToken);

            return new PagedData<DepartmentDto>
             (
                departments,
                request.PageNumber,
                request.PageSize,
                totalCount
             );
        }
    }
}
