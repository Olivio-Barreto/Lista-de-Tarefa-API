using Application.Dto;
using MediatR;

namespace Application.UseCases.Query.GetByName;

public record GetByNameQuery : IRequest<TarefaResponse>
{
    public required string Name { get; init; }
}