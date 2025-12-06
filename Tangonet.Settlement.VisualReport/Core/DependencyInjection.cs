using Microsoft.Extensions.DependencyInjection;
using Tangonet.Settlement.VisualReport.Core.Helpers;

namespace Tangonet.Settlement.VisualReport.Core;
public static class DependencyInjection
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddSingleton<Log>();

        return services;
    }
}
