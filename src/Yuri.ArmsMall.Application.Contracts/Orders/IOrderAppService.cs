namespace Yuri.ArmsMall.Orders;

/// <summary>
/// 
/// </summary>
public interface IOrderAppService
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<(int, List<OrderDto>)> GetPageListAsync();
}
