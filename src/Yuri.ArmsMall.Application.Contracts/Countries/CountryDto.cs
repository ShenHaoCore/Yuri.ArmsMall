using Volo.Abp.Application.Dtos;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public class CountryDto : EntityDto<Guid>
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
}
