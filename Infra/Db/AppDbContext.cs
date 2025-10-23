using Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Infra.Db;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Tarefa>  Tarefas { get; set; }
}