using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Yuri.ArmsMall.IdentityCards;

/// <summary>
/// 
/// </summary>
public class CreateIdentityCardDto
{
    /// <summary>
    /// 姓名
    /// </summary>
    [property: Required]
    [property: DefaultValue("代用名")]
    [property: Description("姓名")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 性别
    /// </summary>
    [property: Required]
    [property: DefaultValue(Sex.FEMALE)]
    [property: Description("性别")]
    public Sex Sex { get; set; }

    /// <summary>
    /// 民族
    /// </summary>
    [property: Required]
    [property: DefaultValue(Nation.HAN)]
    [property: Description("民族")]
    public Nation Nation { get; set; }

    /// <summary>
    /// 出生日期
    /// </summary>
    [property: Required]
    [property: DefaultValue(typeof(DateTime), "2025-05-20")]
    [property: Description("出生日期")]
    public DateTime Birthday { get; set; }

    /// <summary>
    /// 住址
    /// </summary>
    [property: Required]
    [property: DefaultValue("湖南省长沙市开福区巡道街幸福小区居民组")]
    [property: Description("住址")]
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// 公民身份号码
    /// </summary>
    [property: Required]
    [property: DefaultValue("430512198908131367")]
    [property: Description("公民身份号码")]
    public string Number { get; set; } = string.Empty;

    /// <summary>
    /// 起始有效期
    /// </summary>
    [property: Required]
    [property: DefaultValue(typeof(DateTime), "2000-01-01")]
    [property: Description("起始有效期")]
    public DateTime StartDate { get; set; }

    /// <summary>
    /// 截止有效期
    /// </summary>
    [property: Required]
    [property: DefaultValue(typeof(DateTime), "2040-01-01")]
    [property: Description("截止有效期")]
    public DateTime EndDate { get; set; }
}
