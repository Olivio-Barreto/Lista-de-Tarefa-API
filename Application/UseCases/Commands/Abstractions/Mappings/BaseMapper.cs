using AutoMapper;

namespace Application.UseCases.Commands.Abstractions.Mappings;

public abstract class BaseMapper<TEntity, TSource, TDestination> : Profile
{
    protected BaseMapper()
    {
        CreateMap<TSource, TEntity>();
        CreateMap<TEntity, TDestination>();
    }
}