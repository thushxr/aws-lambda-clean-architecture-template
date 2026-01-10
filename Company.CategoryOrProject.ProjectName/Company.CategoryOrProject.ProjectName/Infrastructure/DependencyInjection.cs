using Company.CategoryOrProject.ProjectName.Core.Interfaces;
using Company.CategoryOrProject.ProjectName.Infrastructure.Helpers;
using Company.CategoryOrProject.ProjectName.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Company.CategoryOrProject.ProjectName.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<ISampleRepository, SampleRepository>();
        services.AddScoped<DatabaseHelper>();
        return services;
    }
}
