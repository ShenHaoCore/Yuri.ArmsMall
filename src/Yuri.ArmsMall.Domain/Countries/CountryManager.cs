using JetBrains.Annotations;
using Volo.Abp.Domain.Services;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
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
    /// <param name="name"></param>
    /// <param name="ios2"></param>
    /// <param name="ios3"></param>
    /// <param name="number"></param>
    /// <returns></returns>
    /// <exception cref="CountryAlreadyExistsException"></exception>
    public async Task<Country> CreateAsync([NotNull] string ios2, [NotNull] string ios3, [NotNull] string number, [NotNull] string name)
    {
        //Check.NotNullOrWhiteSpace(name, nameof(name));
        //Check.NotNullOrWhiteSpace(ios2, nameof(ios2));
        //Check.NotNullOrWhiteSpace(ios3, nameof(ios3));
        //Check.NotNullOrWhiteSpace(number, nameof(number));
        //var existingCountry = await _countryRepository.FindAsync(it => it.IOS2 == ios2);
        //if (existingCountry != null) { throw new CountryAlreadyExistsException(ios2); }
        await Task.CompletedTask;
        return new Country(GuidGenerator.Create(), ios2, ios3, number, name);
    }
}
