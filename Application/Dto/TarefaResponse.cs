namespace Application.Dto;

public record TarefaResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
}