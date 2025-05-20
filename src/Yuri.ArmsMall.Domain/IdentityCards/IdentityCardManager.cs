using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Services;
using Yuri.ArmsMall.Countries;

namespace Yuri.ArmsMall.IdentityCards;

/// <summary>
/// 身份证
/// </summary>
public class IdentityCardManager : DomainService
{
    private readonly IIdentityCardRepository _identityCardRepository;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="identityCardRepository"></param>
    public IdentityCardManager(IIdentityCardRepository identityCardRepository)
    {
        _identityCardRepository = identityCardRepository;
    }

    /// <summary>
    /// 创建
    /// </summary>
    /// <param name="name">姓名</param>
    /// <param name="sex">性别</param>
    /// <param name="nation">民族</param>
    /// <param name="birthday">生日</param>
    /// <param name="address">住址</param>
    /// <param name="number">公民身份号码</param>
    /// <param name="startDate">有效期</param>
    /// <param name="endDate">有效期</param>
    /// <returns></returns>
    /// <exception cref="ExistsNumberException"></exception>
    public async Task<IdentityCard> CreateAsync([NotNull] string name, Sex sex, Nation nation, DateTime birthday, [NotNull] string address, [NotNull] string number, DateTime startDate, DateTime endDate)
    {
        Check.NotNullOrWhiteSpace(name, nameof(name));
        Check.NotNullOrWhiteSpace(address, nameof(address));
        Check.NotNullOrWhiteSpace(number, nameof(number));
        var existsCountry = await _identityCardRepository.FindAsync(it => it.Number == number);
        if (existsCountry != null) { throw new ExistsNumberException(number); }
        return new IdentityCard(GuidGenerator.Create(), name, sex, nation, birthday, address, number, startDate, endDate);
    }

    /// <summary>
    /// 修改ISO3编码
    /// </summary>
    /// <param name="identityCard">国家</param>
    /// <param name="newAlpha2">新ISO3编码</param>
    /// <returns></returns>
    /// <exception cref="ExistsAlpha3Exception"></exception>
    public async Task ChangeNumberAsync([NotNull] IdentityCard identityCard, [NotNull] string newNumber)
    {
        Check.NotNull(identityCard, nameof(identityCard));
        Check.NotNullOrWhiteSpace(newNumber, nameof(newNumber));
        var existingIdentityCard = await _identityCardRepository.FindAsync(it => it.Number == newNumber);
        if (existingIdentityCard != null && existingIdentityCard.Id != identityCard.Id) { throw new ExistsAlpha3Exception(newNumber); }
        identityCard.ChangeNumber(newNumber);
    }
}
