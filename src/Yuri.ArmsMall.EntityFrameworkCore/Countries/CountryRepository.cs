using static System.Runtime.InteropServices.JavaScript.JSType;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Yuri.ArmsMall.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public class CountryRepository : EfCoreRepository<ArmsMallDbContext, Country, Guid>, ICountryRepository
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="dbContextProvider"></param>
    public CountryRepository(IDbContextProvider<ArmsMallDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<List<Country>> GetListAsync()
    {
        await Task.CompletedTask;
        return [];
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<(int, List<Country>)> GetPageListAsync()
    {
        await Task.CompletedTask;
        return (0, []);
    }
}
