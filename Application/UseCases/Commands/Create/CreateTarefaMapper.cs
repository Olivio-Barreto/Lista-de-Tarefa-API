using Application.Dto;
using Application.UseCases.Commands.Abstractions.Mappings;
using Core.Domain;

namespace Application.UseCases.Commands.Create;

public class CreateTarefaMapper : BaseMapper<Tarefa, CreateTarefaCommand, TarefaResponse>
{
    public CreateTarefaMapper() : base()
    {
    }
}