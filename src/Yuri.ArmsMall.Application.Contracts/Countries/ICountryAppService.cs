namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public interface ICountryAppService
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<(int, List<CountryDto>)> GetPageListAsync();
}
