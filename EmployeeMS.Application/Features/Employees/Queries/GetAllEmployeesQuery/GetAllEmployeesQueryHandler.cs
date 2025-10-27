using AutoMapper;
using AutoMapper.QueryableExtensions;
using EmployeeMS.Application.Dtos;
using EmployeeMS.Domain.Entities;
using EmployeeMS.Domain.Interfaces.Repositories;
using EmployeeMS.Shared.Wrappers;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMS.Application.Features.Employees.Queries.GetAllEmployeesQuery
{
    public class GetAllEmployeesQueryHandler(IReadOnlyRepository<Employee> readOnlyEmployeeRepository, IMapper mapper)
                                  : IRequestHandler<GetAllEmployeesQuery, PagedData<EmployeeDto>>
    {
        public async Task<PagedData<EmployeeDto>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            var query = readOnlyEmployeeRepository.GetAll();

            var employees = await query
           .Skip((request.PageNumber - 1) * request.PageSize)
           .Take(request.PageSize)
           .ProjectTo<EmployeeDto>(mapper.ConfigurationProvider)
           .ToListAsync(cancellationToken);

            var totalCount = await query.CountAsync(cancellationToken);

            return new PagedData<EmployeeDto>
            (
                employees,
                request.PageNumber,
                request.PageSize,
                totalCount
            );
        }
    }
}
