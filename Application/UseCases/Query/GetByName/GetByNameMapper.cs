using Application.Dto;
using Application.UseCases.Commands.Abstractions.Mappings;
using Core.Domain;

namespace Application.UseCases.Query.GetByName;

public class GetByNameMapper : BaseMapper<Tarefa, GetByNameQuery, TarefaResponse>
{
    public GetByNameMapper() : base()
    {
    }
}