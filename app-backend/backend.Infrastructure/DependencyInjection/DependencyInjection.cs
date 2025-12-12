using Backend.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace Backend.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ITransactionRepository, InMemoryTransactionRepository>();

            return services;
        }
    }
}
