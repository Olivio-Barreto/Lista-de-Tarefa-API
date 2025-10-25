using Application.Dto;
using Application.UseCases.Commands.Abstractions.Mappings;
using Core.Domain;

namespace Application.UseCases.Query.GetCompletedTasks;

public class GetCompletedTasksMapper : BaseMapper<Tarefa, GetCompletedTasksQuery, TarefaResponse>
{
    public GetCompletedTasksMapper() : base()
    {
    }
}