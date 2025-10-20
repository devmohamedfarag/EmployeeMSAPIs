using EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand;
using EmployeeMS.Application.Mappings;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeMS.Application
{
    public static class ApplicationLayerServiceInjector
    {
        public static IServiceCollection AddApplicationLayerServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssembly(typeof(ApplicationLayerServiceInjector).Assembly));

            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssembly(typeof(ApplicationLayerServiceInjector).Assembly);

            services.AddAutoMapper(typeof(ApplicationLayerServiceInjector).Assembly);

            return services;
        }
    }
}