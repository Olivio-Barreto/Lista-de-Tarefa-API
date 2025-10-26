using Application.Dto;
using MediatR;

namespace Application.UseCases.Commands.Update;

public record UpdateTarefaCommand : IRequest<TarefaResponse>
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool? IsCompleted { get; set; }
}