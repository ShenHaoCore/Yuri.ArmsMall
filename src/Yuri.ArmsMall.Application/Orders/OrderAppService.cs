namespace Yuri.ArmsMall.Orders;

/// <summary>
/// 
/// </summary>
public class OrderAppService : IOrderAppService
{
    /// <summary>
    /// 
    /// </summary>
    public OrderAppService()
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<(int, List<OrderDto>)> GetPageListAsync()
    {
        await Task.CompletedTask;
        return (0, []);
    }
}
