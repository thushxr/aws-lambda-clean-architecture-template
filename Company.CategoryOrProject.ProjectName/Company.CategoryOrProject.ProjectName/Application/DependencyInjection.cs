using Company.CategoryOrProject.ProjectName.Application.Interfaces;
using Company.CategoryOrProject.ProjectName.Application.Services;
using Company.CategoryOrProject.ProjectName.Core;
using Microsoft.Extensions.DependencyInjection;

namespace Company.CategoryOrProject.ProjectName.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ISampleAppService, SampleAppService>();
        services.AddCoreServices();
        return services;
    }
}
