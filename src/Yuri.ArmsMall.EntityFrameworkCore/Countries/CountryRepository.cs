namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public class CountryRepository : ICountryRepository
{
    /// <summary>
    /// 
    /// </summary>
    public CountryRepository()
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
