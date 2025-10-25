using Application.Dto;
using MediatR;

namespace Application.UseCases.Query.GetCompletedTasks;

public sealed record GetCompletedTasksQuery : IRequest<List<TarefaResponse>>;