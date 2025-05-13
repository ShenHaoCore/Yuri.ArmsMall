namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public class CountryAppService : ArmsMallAppService, ICountryAppService
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
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<CountryDto> GetAsync(Guid id)
    {
        await Task.CompletedTask;
        return new CountryDto();
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
