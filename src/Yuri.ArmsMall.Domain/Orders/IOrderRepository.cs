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
    Task<List<Order>> GetListAsync();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<(int, List<Order>)> GetPageListAsync();
}
