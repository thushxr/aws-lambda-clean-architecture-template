using Microsoft.Extensions.DependencyInjection;
using Thushar.Project.Kasaragod.Application;
using Thushar.Project.Kasaragod.Core.Helpers;
using Thushar.Project.Kasaragod.Infrastructure;

namespace Thushar.Project.Kasaragod.Lambda;

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
