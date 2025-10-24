using Application.Dto;
using MediatR;

namespace Application.UseCases.Commands.Update;

public record UpdateTarefaCommand : IRequest<TarefaResponse>
{
    public Guid Id { get; set; }
    public string? Name { get; set; } = null;
    public string? Description { get; set; } = null;
    public bool? IsCompleted { get; set; } = null;
}