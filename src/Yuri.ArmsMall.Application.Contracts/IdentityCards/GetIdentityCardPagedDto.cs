using Volo.Abp.Application.Dtos;

namespace Yuri.ArmsMall.IdentityCards;

/// <summary>
/// 
/// </summary>
public class GetIdentityCardPagedDto : PagedAndSortedResultRequestDto
{
    /// <summary>
    /// 
    /// </summary>
    public string? Filter { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 性别
    /// </summary>
    public Sex? Sex { get; set; }

    /// <summary>
    /// 民族
    /// </summary>
    public Nation? Nation { get; set; }
}
