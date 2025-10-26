using AutoMapper;
using EmployeeMS.Application.Dtos;
using EmployeeMS.Application.Features.Professions.Commands.CreateProfessionCommand;
using EmployeeMS.Application.Features.Professions.Commands.UpadateProfessionCommand;
using EmployeeMS.Domain.Entities;

namespace EmployeeMS.Application.Mappings
{
    public class ProfessionMappingProfile : Profile
    {
        public ProfessionMappingProfile()
        {
            CreateMap<CreateProfessionCommand, Profession>();
            CreateMap<Profession, ProfessionDto>();
            CreateMap<UpdateProfessionCommand, Profession>();
        }
    }
}
