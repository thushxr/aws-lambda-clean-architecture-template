using Microsoft.Extensions.DependencyInjection;
using Tangonet.Settlement.VisualReport.Application;
using Tangonet.Settlement.VisualReport.Core.Helpers;
using Tangonet.Settlement.VisualReport.Infrastructure;

namespace Tangonet.Settlement.VisualReport.Lambda;

public class FunctionBase
{
    public readonly Log Logger;

    public FunctionBase()
    {
        var serviceCollection = new ServiceCollection()
            .AddInfrastructureServices()
            .AddApplicationServices();

        var serviceProvider = serviceCollection.BuildServiceProvider();
        Logger = serviceProvider.GetRequiredService<Log>();
    }
}
