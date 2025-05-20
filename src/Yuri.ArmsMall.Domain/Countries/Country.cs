using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 国家
/// </summary>
public class Country : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// ISO2编码
    /// </summary>
    public string Alpha2 { get; private set; } = string.Empty;

    /// <summary>
    /// ISO3编码
    /// </summary>
    public string Alpha3 { get; private set; } = string.Empty;

    /// <summary>
    /// 数字编码
    /// </summary>
    public string Numeric { get; set; } = string.Empty;

    /// <summary>
    /// 中文名
    /// </summary>
    public string NameCn { get; set; } = string.Empty;

    /// <summary>
    /// 英文名
    /// </summary>
    public string NameEn { get; set; } = string.Empty;

    /// <summary>
    /// 国家
    /// </summary>
    private Country()
    {
        /* This constructor is for deserialization / ORM purpose */
    }

    /// <summary>
    /// 国家
    /// </summary>
    /// <param name="id">ID</param>
    /// <param name="alpha2">ISO2编码</param>
    /// <param name="alpha3">ISO3编码</param>
    /// <param name="numeric">数字编码</param>
    /// <param name="nameCn">中文名</param>
    /// <param name="nameEn">英文名</param>
    public Country(Guid id, [NotNull] string alpha2, [NotNull] string alpha3, [NotNull] string numeric, [NotNull] string nameCn, [NotNull] string nameEn) : base(id)
    {
        SetAlpha2(alpha2);
        SetAlpha3(alpha3);
        Numeric = Check.NotNullOrWhiteSpace(numeric, nameof(numeric), maxLength: CountryConsts.MaxNumericLength);
        NameCn = Check.NotNullOrWhiteSpace(nameCn, nameof(nameCn), maxLength: CountryConsts.MaxNameCnLength);
        NameEn = Check.NotNullOrWhiteSpace(nameEn, nameof(nameEn), maxLength: CountryConsts.MaxNameEnLength);
    }

    /// <summary>
    /// 设置ISO2编码
    /// </summary>
    /// <param name="alpha2"></param>
    private void SetAlpha2([NotNull] string alpha2)
    {
        Alpha2 = Check.NotNullOrWhiteSpace(alpha2, nameof(alpha2), maxLength: CountryConsts.Alpha2Length, minLength: CountryConsts.Alpha2Length);
    }

    /// <summary>
    /// 设置ISO3编码
    /// </summary>
    /// <param name="alpha3"></param>
    private void SetAlpha3([NotNull] string alpha3)
    {
        Alpha3 = Check.NotNullOrWhiteSpace(alpha3, nameof(alpha3), maxLength: CountryConsts.Alpha3Length, minLength: CountryConsts.Alpha3Length);
    }

    /// <summary>
    /// 修改ISO2编码
    /// </summary>
    /// <param name="alpha2"></param>
    /// <returns></returns>
    internal Country ChangeAlpha2([NotNull] string alpha2)
    {
        SetAlpha2(alpha2);
        return this;
    }

    /// <summary>
    /// 修改ISO3编码
    /// </summary>
    /// <param name="alpha3"></param>
    /// <returns></returns>
    internal Country ChangeAlpha3([NotNull] string alpha3)
    {
        SetAlpha3(alpha3);
        return this;
    }
}
