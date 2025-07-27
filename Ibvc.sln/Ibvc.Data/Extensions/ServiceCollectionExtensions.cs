using Ibvc.Data.Context;
using Ibvc.Data.Repositories;
using Ibvc.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ibvc.Data.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));

        services.AddScoped<IUsuarioRepository, UsuarioRepository>();

        return services;
    }
}