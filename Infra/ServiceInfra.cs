using Core.Interfaces;
using Infra.Db;
using Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infra;

public static class ServiceInfra
{
    public static void MapInfrastructureService(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ITarefaRepository, TarefaRepository>();

        services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("MeuDatabase"));
    }
}