using Core.Domain;

namespace Core.Interfaces;

public interface ITarefaRepository : IBaseRepository<Tarefa>
{
    Task<Tarefa?> GetByNameAsync(string name);
    Task<List<Tarefa>> GetCompletedTasksAsync(CancellationToken cancellationToken);
    Task<List<Tarefa>> GetUnCompletedTasksAsync(CancellationToken cancellationToken);
}