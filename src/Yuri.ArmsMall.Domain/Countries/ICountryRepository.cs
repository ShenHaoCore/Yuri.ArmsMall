namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public interface ICountryRepository
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
