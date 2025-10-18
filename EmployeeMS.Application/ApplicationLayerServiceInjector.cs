using EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand;
using EmployeeMS.Application.Mappings;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeMS.Application
{
    public static class ApplicationLayerServiceInjector
    {
        public static IServiceCollection AddApplicationLayerServices(this IServiceCollection services)
        {
            services.AddMediatR(
                cfg => cfg.RegisterServicesFromAssemblyContaining<CreateDepartmentCommandHandler>());


            services.AddValidatorsFromAssembly(typeof(CreateDepartmentCommandValidator).Assembly);

            services.AddAutoMapper(typeof(DepartmentMappingProfile).Assembly);

            return services;
        }
    }
}