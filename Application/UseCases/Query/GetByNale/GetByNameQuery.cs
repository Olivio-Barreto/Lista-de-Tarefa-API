using Application.Dto;
using Core.Domain;
using MediatR;

namespace Application.UseCases.Query.GetByNale;

public record GetByNameQuery : IRequest<TarefaResponse>
{
    public required string Name { get; init; }
}