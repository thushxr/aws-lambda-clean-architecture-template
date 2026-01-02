using Company.CategoryOrProject.ProjectName.Infrastructure.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Company.CategoryOrProject.ProjectName.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<DatabaseHelper>();
        return services;
    }
}
