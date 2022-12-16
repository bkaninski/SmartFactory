using SmartFactory.Controllers;
using SmartFactory.Core.Contracts;
using SmartFactory.Core.Services;
using SmartFactory.Infrastructure.Data.Common;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SmartFactoryServiceCollectionExtension
    {
       public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IProductionService, ProductionService>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<ICareerService, CareerService>();
            services.AddScoped<IShiftService, ShiftService>();

            return services;
        }
    }
}
