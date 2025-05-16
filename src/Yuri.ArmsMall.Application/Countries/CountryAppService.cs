namespace Yuri.ArmsMall.Countries;

/// <inheritdoc cref="ICountryAppService"/>
public class CountryAppService : ArmsMallAppService, ICountryAppService
{
    private readonly ICountryRepository _countryRepository;
    private readonly CountryManager _countryManager;

    /// <inheritdoc cref="ICountryAppService"/>
    /// <param name="countryRepository"></param>
    /// <param name="countryManager"></param>
    public CountryAppService(ICountryRepository countryRepository, CountryManager countryManager)
    {
        _countryRepository = countryRepository;
        _countryManager = countryManager;
    }

    /// <inheritdoc/>
    public async Task<CountryDto> GetAsync(Guid id)
    {
        await Task.CompletedTask;
        return new CountryDto();
    }

    /// <inheritdoc/>
    public async Task<List<CountryDto>> GetListAsync()
    {
        List<Country> list = await _countryRepository.GetListAsync();
        return ObjectMapper.Map<List<Country>, List<CountryDto>>(list);
    }

    /// <inheritdoc/>
    public async Task<(int, List<CountryDto>)> GetPageListAsync()
    {
        (int count, List<Country> list) = await _countryRepository.GetPageListAsync();
        return (count, ObjectMapper.Map<List<Country>, List<CountryDto>>(list));
    }
}
