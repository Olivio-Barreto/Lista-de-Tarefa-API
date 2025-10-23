using Application.Dto;
using MediatR;

namespace Application.UseCases.Commands.Create;

public record CreateTarefaCommand : IRequest<TarefaResponse>
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
}