using Core.Domain;
using Core.Interfaces;
using Infra.Db;
using Microsoft.EntityFrameworkCore;

namespace Infra.Persistence;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
    protected AppDbContext Context { get; set; }

    protected BaseRepository(AppDbContext context)
    {
        Context = context;
    }

    public void Create(TEntity entity)
    {
        entity.DateCreated = DateOnly.FromDateTime(DateTime.Now); 
        Context.Set<TEntity>().Add(entity);
    }

    public void Update(TEntity entity)
    {
        entity.DateModified = DateOnly.FromDateTime(DateTime.Now);
        Context.Set<TEntity>().Update(entity);
    }

    public void Delete(TEntity entity)
    {
        entity.DateDeleted = DateOnly.FromDateTime(DateTime.Now);
        Context.Set<TEntity>().Remove(entity);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        var result = await Context.Set<TEntity>().OrderBy(x => x.DateCreated).ToListAsync();
        return result;
    }
}