using Application.Dto;
using MediatR;

namespace Application.UseCases.Commands.Delete;

public record DeleteTarefaCommand : IRequest<TarefaResponse>
{
    public string Name { get; set; } = null!;
}