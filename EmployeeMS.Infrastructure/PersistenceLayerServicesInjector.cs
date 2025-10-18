using EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand;
using EmployeeMS.Domain.Interfaces.Repositories;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using EmployeeMS.Infrastructure.AppDbContext;
using EmployeeMS.Infrastructure.Implementations.Repositories;
using EmployeeMS.Infrastructure.Implementations.UnitOfWork;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeMS.Infrastructure
{
    public static class PersistenceLayerServicesInjector
    {
        public static IServiceCollection AddPersistanceLayerServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddMediatR(typeof(CreateDepartmentCommandHandler).Assembly);
            services.AddValidatorsFromAssembly(typeof(CreateDepartmentCommandValidator).Assembly);

            return services;
        }
    }
}
