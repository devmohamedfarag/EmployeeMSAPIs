using AutoMapper;
using AutoMapper.QueryableExtensions;
using EmployeeMS.Application.Dtos.DepartmentDtos;
using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.Repositories;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using EmployeeMS.Shared.Wrappers;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMS.Application.Features.Departments.Queries.GetAllDepartmentsQuery
{
    public class GetAllDepartmentsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, IReadOnlyRepository<Department> ReadonlyDepartmantRepository)
                                               : IRequestHandler<GetAllDepartmentsQuery, PagedData<DepartmentDto>>
    {
        public async Task<PagedData<DepartmentDto>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
        {
            var query = ReadonlyDepartmantRepository.GetAll();
           
            var departments = await query
                .ProjectTo<DepartmentDto>(mapper.ConfigurationProvider)
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            var totalCount = await query.CountAsync(cancellationToken);

            return new PagedData<DepartmentDto>(
                departments.AsQueryable(),
                request.PageSize,
                request.PageNumber,
                totalCount);
        }
    }
}
