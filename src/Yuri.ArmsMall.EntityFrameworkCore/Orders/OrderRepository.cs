using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Yuri.ArmsMall.EntityFrameworkCore;

namespace Yuri.ArmsMall.Orders;

/// <summary>
/// 
/// </summary>
public class OrderRepository : EfCoreRepository<ArmsMallDbContext, Order, Guid>, IOrderRepository
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="dbContextProvider"></param>
    public OrderRepository(IDbContextProvider<ArmsMallDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<List<Order>> GetListAsync()
    {
        await Task.CompletedTask;
        return [];
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
