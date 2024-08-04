using Microsoft.Extensions.DependencyInjection;
using SampleApp.Application;

namespace SampleApp.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{

    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
