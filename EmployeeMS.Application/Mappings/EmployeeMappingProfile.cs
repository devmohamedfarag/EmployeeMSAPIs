using AutoMapper;
using EmployeeMS.Application.Dtos;
using EmployeeMS.Application.Features.Employees.Commands.CreateEmployeeCommand;
using EmployeeMS.Application.Features.Employees.Commands.UpdateEmployeeCommand;
using EmployeeMS.Domain.Entities;

namespace EmployeeMS.Application.Mappings.EmployeeMappingProfile
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile() 
        {
            CreateMap<CreateEmployeeCommand, Employee>();
            CreateMap<UpdateEmployeeCommand, Employee>();
            CreateMap<Employee, EmployeeDto>(); 
        }
    }
}
