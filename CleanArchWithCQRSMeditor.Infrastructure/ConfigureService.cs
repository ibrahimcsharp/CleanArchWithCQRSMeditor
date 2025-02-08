using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRSMeditor.Infrastructure
{
    /*Infrastructure depends on domain and application layers. 
    It contains classes for data access, logging, configuration, and other infrastructure concerns. 
    It may also contain classes for cross-cutting concerns such as error handling, caching, and validation. 
    Infrastructure classes should be loosely coupled to the rest of the application;
    so they can be easily replaced or updated without affecting other parts of the system.*/
    public static class ConfigureService
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            /*services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());*/

            return services;
        }
    }
}
