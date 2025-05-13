using Volo.Abp.Application.Services;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public interface ICountryAppService : IApplicationService
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<CountryDto> GetAsync(Guid id);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<(int, List<CountryDto>)> GetPageListAsync();
}
