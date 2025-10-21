using AutoMapper;
using EmployeeMS.Application.Dtos.DepartmentDtos;
using EmployeeMS.Application.Features.Departments.Commands.UpdateDepartmentCommand;
using EmployeeMS.Domain.Entities;

namespace EmployeeMS.Application.Mappings.DepartmentMappingProfiles
{
    public class UpdateDepartmentMappingProfile : Profile
    {
        public UpdateDepartmentMappingProfile()
        {
            CreateMap<Department, DepartmentDto>();

            CreateMap<UpdateDepartmentCommand, Department>();
        }
    }
}
