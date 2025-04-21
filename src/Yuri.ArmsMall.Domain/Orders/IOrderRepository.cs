namespace Yuri.ArmsMall.Orders;

/// <summary>
/// 
/// </summary>
public interface IOrderRepository
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<(int, List<Order>)> GetPageListAsync();
}
