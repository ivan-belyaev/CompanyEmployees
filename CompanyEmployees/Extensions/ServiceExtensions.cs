using Contracts;
using Entities;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;

namespace CompanyEmployees.Extensions
{
    /// <summary>
    /// Service section
    /// </summary>
    public static class ServiceExtensions
    {
        /// <summary>
        /// CORS configuration
        /// </summary>
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                // send requests from a different domain to our application: AllowAnyOrigin
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    // allows all HTTP methods
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

        /// <summary>
        /// IIS Configuration
        /// </summary>
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
            {
                // host our application on IIS. We do not initialize any of the properties 
                // inside the options because we are fine with the default values for now 
            });

        /// <summary>
        /// Configure Logger Nlog: Scoped
        /// </summary>
        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();

        /// <summary>
        /// Configure Database: PostgreSQL
        /// </summary>
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(opts => opts.UseNpgsql(configuration.GetConnectionString("sqlConnection"), b => b.MigrationsAssembly("CompanyEmployees")));

        /// <summary>
        /// Configure Repository Manager: Scoped
        /// </summary>
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
           services.AddScoped<IRepositoryManager, RepositoryManager>();

    }
}
