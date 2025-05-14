using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public class Country : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// IOS3
    /// </summary>
    public string IOS2 { get; set; } = string.Empty;

    /// <summary>
    /// IOS3
    /// </summary>
    public string IOS3 { get; set; } = string.Empty;

    /// <summary>
    /// 编号
    /// </summary>
    public string Number { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; } = string.Empty;

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
    /// <param name="id"></param>
    /// <param name="name"></param>
    public Country(Guid id, [NotNull] string ios2, [NotNull] string ios3, [NotNull] string number, [NotNull] string name) : base(id)
    {
        IOS2 = Check.NotNullOrWhiteSpace(ios2, nameof(ios2), maxLength: CountryConsts.Ios2Length, minLength: CountryConsts.Ios2Length);
        IOS3 = Check.NotNullOrWhiteSpace(ios3, nameof(ios3), maxLength: CountryConsts.Ios3Length, minLength: CountryConsts.Ios2Length);
        Number = Check.NotNullOrWhiteSpace(number, nameof(number), maxLength: CountryConsts.MaxNumberLength);
        Name = Check.NotNullOrWhiteSpace(name, nameof(name), maxLength: CountryConsts.MaxNameLength);
    }
}
