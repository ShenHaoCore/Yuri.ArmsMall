using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Yuri.ArmsMall.Countries;
using Yuri.ArmsMall.EntityFrameworkCore;

namespace Yuri.ArmsMall.IdentityCards;

/// <inheritdoc cref="IIdentityCardRepository"/>
public class IdentityCardRepository : EfCoreRepository<ArmsMallDbContext, IdentityCard, Guid>, IIdentityCardRepository
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="dbContextProvider"></param>
    public IdentityCardRepository(IDbContextProvider<ArmsMallDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    /// <inheritdoc/>
    public async Task<List<IdentityCard>> GetListAsync()
    {
        ArmsMallDbContext db = await GetDbContextAsync();
        IQueryable<IdentityCard> dbSet = db.IdentityCards;
        return await dbSet.ToListAsync();
    }

    /// <inheritdoc/>
    public async Task<(int, List<IdentityCard>)> GetPagedAsync(int skipCount, int maxResultCount, string sorting, string? filter = null)
    {
        ArmsMallDbContext db = await GetDbContextAsync();
        IQueryable<IdentityCard> dbSet = db.IdentityCards;
        return (await dbSet.CountAsync(), await dbSet.Skip(0).Take(20).ToListAsync());
    }
}
