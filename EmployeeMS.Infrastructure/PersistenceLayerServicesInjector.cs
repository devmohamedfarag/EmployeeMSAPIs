using EmployeeMS.Domain.Interfaces.Repositories;
using EmployeeMS.Domain.Interfaces.UnitOfWork;
using EmployeeMS.Infrastructure.AppDbContext;
using EmployeeMS.Infrastructure.Repositories;
using EmployeeMS.Infrastructure.UnitOfWorkImbl;
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

            return services;
        }
    }
}
