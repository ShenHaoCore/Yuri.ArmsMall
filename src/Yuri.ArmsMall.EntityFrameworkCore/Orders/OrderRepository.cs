namespace Yuri.ArmsMall.Orders;

/// <summary>
/// 
/// </summary>
public class OrderRepository : IOrderRepository
{
    /// <summary>
    /// 
    /// </summary>
    public OrderRepository()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<(int, List<Order>)> GetPageListAsync()
    {
        await Task.CompletedTask;
        return (0, []);
    }
}
