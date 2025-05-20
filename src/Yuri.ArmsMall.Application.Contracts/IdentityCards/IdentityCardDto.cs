using Volo.Abp.Application.Dtos;

namespace Yuri.ArmsMall.IdentityCards;

/// <summary>
/// 
/// </summary>
public class IdentityCardDto : EntityDto<Guid>
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
}
