using Volo.Abp.Domain.Entities.Auditing;

namespace Yuri.ArmsMall.Orders;

/// <summary>
/// 订单
/// </summary>
public class Order : FullAuditedAggregateRoot<Guid>
{
    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get; set; } = string.Empty;

    /// <summary>
    /// 订单
    /// </summary>
    private Order()
    {
        /* This constructor is for deserialization / ORM purpose */
    }

    /// <summary>
    /// 订单
    /// </summary>
    /// <param name="remark"></param>
    public Order(string remark)
    {
        Remark = remark;
    }
}
