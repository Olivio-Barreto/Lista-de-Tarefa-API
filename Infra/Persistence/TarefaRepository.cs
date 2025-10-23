using Core.Domain;
using Core.Interfaces;
using Infra.Db;
using Microsoft.EntityFrameworkCore;

namespace Infra.Persistence;

public class TarefaRepository : BaseRepository<Tarefa>, ITarefaRepository
{
    public TarefaRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Tarefa?> GetByNameAsync(string name)
    {
        return await Context.Tarefas.FirstOrDefaultAsync(x => x.Name == name);
    }

    public async Task<List<Tarefa>> GetCompletedTasksAsync(CancellationToken cancellationToken)
    {
        return await Context.Tarefas
            .Where(x => x.IsCompleted == true)
            .ToListAsync(cancellationToken);
    }

    public async Task<List<Tarefa>> GetUnCompletedTasksAsync(CancellationToken cancellationToken)
    {
        return await Context.Tarefas
            .Where(x => x.IsCompleted == false)
            .ToListAsync(cancellationToken);
    }
}