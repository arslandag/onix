using Fenix.Application.Database;
using Fenix.Infrastructure.DateBase.DbContexts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fenix.Infrastructure.DateBase;

public static class Inject
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection service, IConfiguration configuration)
    {
        service.AddDatabase();
        service.AddDbContext();
        
        return service;
    }

    private static IServiceCollection AddDbContext(this IServiceCollection service)
    {
        service.AddScoped<WriteDbContext>();
        service.AddScoped<IReadDbContext,ReadDbContext>();
        
        return service;
    }
    
    private static IServiceCollection AddDatabase(this IServiceCollection services)
    {
        services.AddSingleton<ISqlConnectionFactory, SqlConnectionFactory>();

        return services;
    }
}