using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public class UpdateCountryDto
{
    /// <summary>
    /// ISO2编码
    /// </summary>
    [property: Required]
    [property: DefaultValue("CN")]
    [property: Description("ISO2编码")]
    public string Alpha2 { get; set; } = string.Empty;

    /// <summary>
    /// ISO3编码
    /// </summary>
    [property: Required]
    [property: DefaultValue("CHN")]
    [property: Description("ISO3编码")]
    public string Alpha3 { get; set; } = string.Empty;

    /// <summary>
    /// 数字编码
    /// </summary>
    [property: Required]
    [property: DefaultValue("156")]
    [property: Description("数字编码")]
    public string Numeric { get; set; } = string.Empty;

    /// <summary>
    /// 中文名
    /// </summary>
    [property: Required]
    [property: DefaultValue("中国")]
    [property: Description("中文名")]
    public string NameCn { get; set; } = string.Empty;

    /// <summary>
    /// 英文名
    /// </summary>
    [property: Required]
    [property: DefaultValue("China")]
    [property: Description("英文名")]
    public string NameEn { get; set; } = string.Empty;
}
