using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SampleApp.Application.Repositories;
using SampleApp.Infrastructure.EFCore.Repositories;

namespace SampleApp.Infrastructure.EFCore.Extensions;
// TODO: rename assembly from EFCore to Persistence

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<SampleAppDbContext>(opt =>
        {
            var connectionString = configuration.GetConnectionString("SqliteLocal");
            opt.UseSqlite(connectionString);
        });
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}
