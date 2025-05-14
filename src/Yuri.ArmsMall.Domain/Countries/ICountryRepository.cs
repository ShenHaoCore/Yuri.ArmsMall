using Volo.Abp.Domain.Repositories;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 国家仓储
/// </summary>
public interface ICountryRepository : IRepository<Country, Guid>
{
    /// <summary>
    /// 获取列表
    /// </summary>
    /// <returns></returns>
    Task<List<Country>> GetListAsync();

    /// <summary>
    /// 获取分页
    /// </summary>
    /// <returns></returns>
    Task<(int, List<Country>)> GetPageListAsync();
}
