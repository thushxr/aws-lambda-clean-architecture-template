using Company.CategoryOrProject.ProjectName.Core.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Company.CategoryOrProject.ProjectName.Core;
public static class DependencyInjection
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddSingleton<Log>();
        return services;
    }
}
