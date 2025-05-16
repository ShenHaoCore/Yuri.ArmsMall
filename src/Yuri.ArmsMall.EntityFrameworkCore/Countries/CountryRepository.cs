using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Yuri.ArmsMall.EntityFrameworkCore;

namespace Yuri.ArmsMall.Countries;

/// <inheritdoc cref="ICountryRepository"/>
public class CountryRepository : EfCoreRepository<ArmsMallDbContext, Country, Guid>, ICountryRepository
{
    /// <inheritdoc cref="ICountryRepository"/>
    /// <param name="dbContextProvider"></param>
    public CountryRepository(IDbContextProvider<ArmsMallDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    /// <inheritdoc/>
    public async Task<List<Country>> GetListAsync()
    {
        ArmsMallDbContext db = await GetDbContextAsync();
        IQueryable<Country> dbSet = db.Countries;
        List<Country> countries = await dbSet.ToListAsync();
        return countries;
    }

    /// <inheritdoc/>
    public async Task<(int, List<Country>)> GetPageListAsync()
    {
        ArmsMallDbContext db = await GetDbContextAsync();
        IQueryable<Country> dbSet = db.Countries;
        int count = await dbSet.CountAsync();
        List<Country> countries = await dbSet.Skip(0).Take(20).ToListAsync();
        return (count, countries);
    }
}
