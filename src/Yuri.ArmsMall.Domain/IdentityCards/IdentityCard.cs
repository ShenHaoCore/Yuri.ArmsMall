using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Yuri.ArmsMall.IdentityCards;

/// <summary>
/// 
/// </summary>
public class IdentityCard : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 姓名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 性别
    /// </summary>
    public Sex Sex { get; set; }

    /// <summary>
    /// 民族
    /// </summary>
    public Nation Nation { get; set; }

    /// <summary>
    /// 出生日期
    /// </summary>
    public DateTime Birthday { get; set; }

    /// <summary>
    /// 住址
    /// </summary>
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// 公民身份号码
    /// </summary>
    public string Number { get; private set; } = string.Empty;

    /// <summary>
    /// 有效期
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// 有效期
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// 身份证
    /// </summary>
    private IdentityCard()
    {
        /* This constructor is for deserialization / ORM purpose */
    }

    /// <summary>
    /// 身份证
    /// </summary>
    /// <param name="id">ID</param>
    /// <param name="name">姓名</param>
    /// <param name="sex">性别</param>
    /// <param name="nation">民族</param>
    /// <param name="birthday">生日</param>
    /// <param name="address">住址</param>
    /// <param name="number">公民身份号码</param>
    /// <param name="startDate">有效期</param>
    /// <param name="endDate">有效期</param>
    public IdentityCard(Guid id, [NotNull] string name, Sex sex, Nation nation, DateTime birthday, [NotNull] string address, [NotNull] string number, DateTime startDate, DateTime endDate) : base(id)
    {
        Name = Check.NotNullOrWhiteSpace(name, nameof(name), maxLength: IdentityCardConsts.MaxNameLength);
        Sex = sex;
        Nation = nation;
        Birthday = birthday;
        Address = Check.NotNullOrWhiteSpace(address, nameof(address), maxLength: IdentityCardConsts.MaxAddressLength);
        SetNumber(number);
        StartDate = startDate;
        EndDate = endDate;
    }

    /// <summary>
    /// 设置身份证号
    /// </summary>
    /// <param name="number"></param>
    private void SetNumber([NotNull] string number)
    {
        Number = Check.NotNullOrWhiteSpace(number, nameof(number), maxLength: IdentityCardConsts.NumberLength, minLength: IdentityCardConsts.NumberLength);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    internal IdentityCard ChangeNumber([NotNull] string number)
    {
        SetNumber(number);
        return this;
    }
}
