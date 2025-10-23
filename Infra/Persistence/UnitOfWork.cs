using Core.Interfaces;
using Infra.Db;

namespace Infra.Persistence;

public class UnitOfWork(AppDbContext appDbContext) : IUnitOfWork
{
    public async Task Commit(CancellationToken cancellationToken)
    {
        await appDbContext.SaveChangesAsync(cancellationToken);
    }
}