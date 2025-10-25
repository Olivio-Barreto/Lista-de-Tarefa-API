using Application.Dto;
using MediatR;

namespace Application.UseCases.Query.GetUnCompletedTasks;

public sealed record GetUnCompletedTasksQuery : IRequest<List<TarefaResponse>>;