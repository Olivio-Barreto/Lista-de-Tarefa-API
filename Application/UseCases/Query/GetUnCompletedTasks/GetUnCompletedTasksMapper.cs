using Application.Dto;
using Application.UseCases.Commands.Abstractions.Mappings;
using Core.Domain;

namespace Application.UseCases.Query.GetUnCompletedTasks;

public sealed class GetUnCompletedTasksMapper : BaseMapper<Tarefa, GetUnCompletedTasksQuery, TarefaResponse>
{
    public GetUnCompletedTasksMapper() : base()
    {
    }
}