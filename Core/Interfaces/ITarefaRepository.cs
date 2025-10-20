using Core.Domain;

namespace Core.Interfaces;

public interface ITarefaRepository : IBaseRepository<Tarefa>
{
    Task<List<Tarefa>> GetByName(string name);
    Task<List<Tarefa>> GetCompletedTasks(CancellationToken cancellationToken);
    Task<List<Tarefa>> GetUnCompletedTasks(CancellationToken cancellationToken);
}