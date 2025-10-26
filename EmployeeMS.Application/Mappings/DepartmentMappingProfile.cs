using AutoMapper;
using EmployeeMS.Application.Dtos;
using EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand;
using EmployeeMS.Application.Features.Departments.Commands.UpdateDepartmentCommand;
using EmployeeMS.Domain.Entities;

namespace EmployeeMS.Application.Mappings.DepartmentMappingProfiles
{
    public class DepartmentMappingProfile : Profile
    {
        public DepartmentMappingProfile()
        {
            CreateMap<CreateDepartmentCommand, Department>();
            CreateMap<Department, DepartmentDto>();
            CreateMap<UpdateDepartmentCommand, Department>();
        }
    }
}
