using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SampleApp.Application.Repositories;
using SampleApp.Infrastructure.Persistence.Repositories;

namespace SampleApp.Infrastructure.Persistence.Extensions;

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
