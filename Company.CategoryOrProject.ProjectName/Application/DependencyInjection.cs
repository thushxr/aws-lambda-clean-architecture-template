using Company.CategoryOrProject.ProjectName.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Company.CategoryOrProject.ProjectName.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddCoreServices();
        return services;
    }
}
