using ApplicationServices.Handlers;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ApplicationServices;

public static class ApplicationServiceServices
{
    public static void AddApplicationService(this IServiceCollection services)
    {

        Assembly assembly = typeof(IOverTimeHandler).Assembly;

        var types = Assembly.GetExecutingAssembly()
                                       .GetTypes()
                                       .Where(t => typeof(IOverTimeHandler).IsAssignableFrom(t) && t.IsClass);

        foreach (var node in types)
            services.AddTransient(typeof(IOverTimeHandler), node);


        services.AddTransient<IOverTimeCalculatorHandler, OverTimeCalculatorHandler>();

    }
}
