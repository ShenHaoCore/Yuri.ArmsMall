using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Yuri.ArmsMall.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        await Task.CompletedTask;
        return [];
    }

    /// <inheritdoc/>
    public async Task<(int, List<Country>)> GetPageListAsync()
    {
        await Task.CompletedTask;
        return (1, [new Country(GuidGenerator.Create(), "CN", "CHN", "156", "中国")]);
    }
}
