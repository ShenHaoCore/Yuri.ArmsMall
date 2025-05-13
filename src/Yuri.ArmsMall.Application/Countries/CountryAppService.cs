namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public class CountryAppService : ICountryAppService
{
    /// <summary>
    /// 
    /// </summary>
    public CountryAppService()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<(int, List<CountryDto>)> GetPageListAsync()
    {
        await Task.CompletedTask;
        return (0, []);
    }
}
