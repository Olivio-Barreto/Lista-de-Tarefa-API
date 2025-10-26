using Application.Dto;
using MediatR;

namespace Application.UseCases.Query.GetAll;

public record GetAllTarefasQuery : IRequest<IEnumerable<TarefaResponse>>;