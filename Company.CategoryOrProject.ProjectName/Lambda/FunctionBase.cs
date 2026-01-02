using Microsoft.Extensions.DependencyInjection;
using Company.CategoryOrProject.ProjectName.Application;
using Company.CategoryOrProject.ProjectName.Core.Helpers;
using Company.CategoryOrProject.ProjectName.Infrastructure;

namespace Company.CategoryOrProject.ProjectName.Lambda;

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
