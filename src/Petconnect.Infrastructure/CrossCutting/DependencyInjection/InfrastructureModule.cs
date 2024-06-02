using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Petconnect.Domain.Interfaces.Repositories;
using Petconnect.Infrastructure.Data.Context;
using Petconnect.Infrastructure.Data.Repositories;

namespace Petconnect.Infrastructure.CrossCutting.DependencyInjection;
public static class InfrastructureModule {
    public static IServiceCollection AddInfrastructure(this IServiceCollection services) {
        services.AddRepositories();

        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services) {
        var connectionString = "Host=localhost;Port=5433;Database=petconnect;Username=roberto;Password=petconnect2024";
        services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

        services.AddDbContext<DataContext>(
            options => options.UseNpgsql(connectionString)
        );

        return services;
    }
}
