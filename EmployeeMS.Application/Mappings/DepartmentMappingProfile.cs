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
            CreateMap<Department, DepartmentWithEmployeesDto>()
                .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Employees, opt => opt.MapFrom(src => src.Employees));

        }
    }
}
