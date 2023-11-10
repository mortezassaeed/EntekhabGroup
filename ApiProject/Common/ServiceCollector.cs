using Infrastructure;
using ApplicationServices;
using Microsoft.Extensions.DependencyInjection;


namespace Common;

public static class ServiceCollector
{
    public static void AddCores(this IServiceCollection services)
    {
        services.AddInfrastructure();
        services.AddApplicationService();
    }
}
