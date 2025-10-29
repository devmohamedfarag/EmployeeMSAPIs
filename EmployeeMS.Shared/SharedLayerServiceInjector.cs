using EmployeeMS.Shared.Middelwares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Globalization;

namespace EmployeeMS.Shared
{
    public static class SharedLayerServiceInjector
    {
        public static IServiceCollection AddSharedLayerServices(this IServiceCollection services)
        {
            services.AddLocalization(options => options.ResourcesPath = "LocalizationResources");

            var supportedCultures = new[]
             {
                new CultureInfo("en"),
                new CultureInfo("ar")
            };

            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture("en");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });

            return services;
        }

        public static IApplicationBuilder UseSharedLayerLocalization(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionHandlingMiddelware>();

            var locOptions = app.ApplicationServices.GetRequiredService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(locOptions.Value);
            
            return app;
        }
    }
}
