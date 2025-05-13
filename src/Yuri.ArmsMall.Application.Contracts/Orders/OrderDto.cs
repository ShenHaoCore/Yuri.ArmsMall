using Volo.Abp.Application.Dtos;

namespace Yuri.ArmsMall.Orders;

/// <summary>
/// 
/// </summary>
public class OrderDto : EntityDto<Guid>
{
    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get; set; } = string.Empty;
}
