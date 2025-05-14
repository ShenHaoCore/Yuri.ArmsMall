using Volo.Abp.Application.Services;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public interface ICountryAppService : IApplicationService
{
    /// <summary>
    /// 获取实体
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<CountryDto> GetAsync(Guid id);

    /// <summary>
    /// 获取分页
    /// </summary>
    /// <returns></returns>
    Task<(int, List<CountryDto>)> GetPageListAsync();
}
