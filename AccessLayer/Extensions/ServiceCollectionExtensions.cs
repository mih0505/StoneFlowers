using ApplicationLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AccessLayer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAccessLayer(
        this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ISU");

            services.AddDbContext<StoneFlowersDbContext>
            (
                options => options.UseSqlServer(connectionString)
            );

            services.AddScoped<IStoneFlowersDbContext>
            (
                provider => provider.GetService<StoneFlowersDbContext>()
            );

            return services;
        }
    }
}
