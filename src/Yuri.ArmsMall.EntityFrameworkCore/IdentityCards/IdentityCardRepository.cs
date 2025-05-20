using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
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
        List<IdentityCard> identityCards = await dbSet.ToListAsync();
        return identityCards;
    }
}
