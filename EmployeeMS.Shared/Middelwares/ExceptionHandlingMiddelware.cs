using EmployeeMS.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Text.Json;

namespace EmployeeMS.Shared.Middelwares
{
    public class ExceptionHandlingMiddelware(ILogger<ExceptionHandlingMiddelware> logger, RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception exception)
            {
                logger.LogError(exception, "An unhandled exception occurred.");
                await HandleExceptionAsync(context, exception);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            var statusCode = exception switch
            {
                KeyNotFoundException => (int)HttpStatusCode.NotFound,
                _ => (int)HttpStatusCode.InternalServerError
            };

            var errorDto = new ErrorDto(statusCode, exception.Message);

            var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            var jsonResponse = JsonSerializer.Serialize(errorDto, options);

            context.Response.StatusCode = statusCode;
            await context.Response.WriteAsync(jsonResponse);
        }
    }
}