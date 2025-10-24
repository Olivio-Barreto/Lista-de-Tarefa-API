using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ServiceApplication
{
    public static void MapApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ServiceApplication).Assembly);
        services.AddValidatorsFromAssembly(typeof(ServiceApplication).Assembly);
        services.AddMediatR(config =>
            config.RegisterServicesFromAssembly(typeof(ServiceApplication).Assembly));
    }
}