using Thushar.Project.Kasaragod.Core.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Thushar.Project.Kasaragod.Core;
public static class DependencyInjection
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddSingleton<Log>();
        return services;
    }
}
