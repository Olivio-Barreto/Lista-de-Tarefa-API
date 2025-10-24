using Application.Dto;
using Application.UseCases.Commands.Abstractions.Mappings;
using Core.Domain;

namespace Application.UseCases.Commands.Update;

public sealed class UpdateTarefaMapper : BaseMapper<Tarefa, UpdateTarefaCommand, TarefaResponse>
{
    public UpdateTarefaMapper() : base()
    {
    }
}