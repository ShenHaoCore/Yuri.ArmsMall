using Volo.Abp.Domain.Repositories;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public interface ICountryRepository : IRepository<Country, Guid>
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<List<Country>> GetListAsync();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<(int, List<Country>)> GetPageListAsync();
}
