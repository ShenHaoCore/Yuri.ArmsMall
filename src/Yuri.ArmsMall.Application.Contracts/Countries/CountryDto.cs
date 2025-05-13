using Volo.Abp.Application.Dtos;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public class CountryDto : EntityDto<Guid>
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
}
