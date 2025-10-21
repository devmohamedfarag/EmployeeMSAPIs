using AutoMapper;
using EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand;
using EmployeeMS.Domain.Entities;

namespace EmployeeMS.Application.Mappings.DepartmentMappingProfiles
{
    public class CreateDepartmentMappingProfile : Profile
    {
        public CreateDepartmentMappingProfile()
        {
            CreateMap<CreateDepartmentCommand, Department>();
        }
    }
}
