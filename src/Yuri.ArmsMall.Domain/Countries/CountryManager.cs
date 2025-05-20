using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 国家
/// </summary>
public class CountryManager : DomainService
{
    private readonly ICountryRepository _countryRepository;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="countryRepository"></param>
    public CountryManager(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="alpha2"></param>
    /// <param name="alpha3"></param>
    /// <param name="numeric"></param>
    /// <param name="nameCn"></param>
    /// <param name="nameEn"></param>
    /// <returns></returns>
    /// <exception cref="CountryAlreadyExistsAlpha3Exception"></exception>
    public async Task<Country> CreateAsync([NotNull] string alpha2, [NotNull] string alpha3, [NotNull] string numeric, [NotNull] string nameCn, [NotNull] string nameEn)
    {
        Check.NotNullOrWhiteSpace(alpha2, nameof(alpha2));
        Check.NotNullOrWhiteSpace(alpha3, nameof(alpha3));
        Check.NotNullOrWhiteSpace(numeric, nameof(numeric));
        Check.NotNullOrWhiteSpace(nameCn, nameof(nameCn));
        Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn));
        var alpha2Country = await _countryRepository.FindAsync(it => it.Alpha2 == alpha2);
        if (alpha2Country != null) { throw new CountryAlreadyExistsAlpha2Exception(alpha3); }
        var alpha3Country = await _countryRepository.FindAsync(it => it.Alpha3 == alpha3);
        if (alpha3Country != null) { throw new CountryAlreadyExistsAlpha3Exception(alpha3); }
        return new Country(GuidGenerator.Create(), alpha2, alpha3, numeric, nameCn, nameEn);
    }

    /// <summary>
    /// 修改ISO2编码
    /// </summary>
    /// <param name="country">国家</param>
    /// <param name="newAlpha2">新ISO2编码</param>
    /// <returns></returns>
    /// <exception cref="CountryAlreadyExistsAlpha2Exception"></exception>
    public async Task ChangeAlpha2Async([NotNull] Country country, [NotNull] string newAlpha2)
    {
        Check.NotNull(country, nameof(country));
        Check.NotNullOrWhiteSpace(newAlpha2, nameof(newAlpha2));
        var existingCountry = await _countryRepository.FindAsync(it => it.Alpha2 == newAlpha2);
        if (existingCountry != null && existingCountry.Id != country.Id) { throw new CountryAlreadyExistsAlpha2Exception(newAlpha2); }
        country.ChangeAlpha2(newAlpha2);
    }

    /// <summary>
    /// 修改ISO3编码
    /// </summary>
    /// <param name="country">国家</param>
    /// <param name="newAlpha2">新ISO2编码</param>
    /// <returns></returns>
    /// <exception cref="CountryAlreadyExistsAlpha3Exception"></exception>
    public async Task ChangeAlpha3Async([NotNull] Country country, [NotNull] string newAlpha3)
    {
        Check.NotNull(country, nameof(country));
        Check.NotNullOrWhiteSpace(newAlpha3, nameof(newAlpha3));
        var existingCountry = await _countryRepository.FindAsync(it => it.Alpha3 == newAlpha3);
        if (existingCountry != null && existingCountry.Id != country.Id) { throw new CountryAlreadyExistsAlpha3Exception(newAlpha3); }
        country.ChangeAlpha3(newAlpha3);
    }
}
