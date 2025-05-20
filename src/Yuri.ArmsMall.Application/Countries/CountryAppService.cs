namespace Yuri.ArmsMall.Countries;

/// <inheritdoc cref="ICountryAppService"/>
public class CountryAppService : ArmsMallAppService, ICountryAppService
{
    private readonly ICountryRepository _countryRepository;
    private readonly CountryManager _countryManager;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="countryRepository"></param>
    /// <param name="countryManager"></param>
    public CountryAppService(ICountryRepository countryRepository, CountryManager countryManager)
    {
        _countryRepository = countryRepository;
        _countryManager = countryManager;
    }

    /// <inheritdoc/>
    public async Task<CountryDto> CreateAsync(CreateCountryDto input)
    {
        Country country = await _countryManager.CreateAsync(input.Alpha2, input.Alpha3, input.Numeric, input.NameCn, input.NameEn);
        await _countryRepository.InsertAsync(country);
        return ObjectMapper.Map<Country, CountryDto>(country);
    }

    /// <inheritdoc/>
    public async Task DeleteAsync(Guid id)
    {
        await _countryRepository.DeleteAsync(id);
    }

    /// <inheritdoc/>
    public async Task UpdateAsync(Guid id, UpdateCountryDto input)
    {
        Country country = await _countryRepository.GetAsync(id);
        if (country.Alpha2 != input.Alpha2) { await _countryManager.ChangeAlpha2Async(country, input.Alpha2); }
        if (country.Alpha3 != input.Alpha3) { await _countryManager.ChangeAlpha3Async(country, input.Alpha3); }
        if (country.Numeric != input.Numeric) { await _countryManager.ChangeNumericAsync(country, input.Numeric); }
        country.NameCn = input.NameCn;
        country.NameEn = input.NameEn;
        await _countryRepository.UpdateAsync(country);
    }

    /// <inheritdoc/>
    public async Task<CountryDto> GetAsync(Guid id)
    {
        Country country = await _countryRepository.GetAsync(id);
        return ObjectMapper.Map<Country, CountryDto>(country);
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
