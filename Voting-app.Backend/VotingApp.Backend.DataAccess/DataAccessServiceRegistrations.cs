using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace VotingApp.Backend.DataAccess;

public static class DataAccessServiceRegistrations
{
    public static IServiceCollection ConfigureDataAccess(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<Context>(options => options.UseSqlServer(configuration.GetConnectionString("main")));

        return services;
    }
}