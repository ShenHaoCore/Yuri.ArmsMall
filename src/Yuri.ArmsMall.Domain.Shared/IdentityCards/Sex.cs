using System.ComponentModel;

namespace Yuri.ArmsMall.IdentityCards;

/// <summary>
/// 性别
/// </summary>
public enum Sex
{
    /// <summary>
    /// 女性
    /// </summary>
    [Description("女")]
    FEMALE = 0,

    /// <summary>
    /// 男性
    /// </summary>
    [Description("男")]
    MALE = 1
}
