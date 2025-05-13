using Volo.Abp.Domain.Repositories;

namespace Yuri.ArmsMall.Orders;

/// <summary>
/// 
/// </summary>
public interface IOrderRepository : IRepository<Order, Guid>
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
