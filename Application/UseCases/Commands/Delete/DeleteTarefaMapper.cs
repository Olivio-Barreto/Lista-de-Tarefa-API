using Application.Dto;
using Application.UseCases.Commands.Abstractions.Mappings;
using Core.Domain;

namespace Application.UseCases.Commands.Delete;

public class DeleteTarefaMapper : BaseMapper<Tarefa, DeleteTarefaCommand, TarefaResponse>
{
    public DeleteTarefaMapper() : base()
    {
    }
}