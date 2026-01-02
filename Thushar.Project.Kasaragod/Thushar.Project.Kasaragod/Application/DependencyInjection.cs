using Thushar.Project.Kasaragod.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Thushar.Project.Kasaragod.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddCoreServices();
        return services;
    }
}
