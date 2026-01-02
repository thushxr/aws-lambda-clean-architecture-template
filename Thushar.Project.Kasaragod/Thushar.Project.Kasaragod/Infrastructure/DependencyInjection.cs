using Thushar.Project.Kasaragod.Infrastructure.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Thushar.Project.Kasaragod.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<DatabaseHelper>();
        return services;
    }
}
