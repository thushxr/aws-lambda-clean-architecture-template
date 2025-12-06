using Microsoft.Extensions.DependencyInjection;
using Tangonet.Settlement.VisualReport.Core;
using Tangonet.Settlement.VisualReport.Infrastructure.Helpers;

namespace Tangonet.Settlement.VisualReport.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<DatabaseHelper>();
        services.AddCoreServices();

        return services;
    }
}
