using Infrastructure.SalaryRequestParser;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class InfrastructureServices
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<ISalaryRequestParserFactory, SalaryRequestParserFactory>();
    }
}
