using Core.Domain;

namespace Core.Interfaces;

public interface IBaseRepository<TEntity>  where TEntity : BaseEntity
{
    void Create(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    Task<IEnumerable<TEntity>>  GetAll();
}