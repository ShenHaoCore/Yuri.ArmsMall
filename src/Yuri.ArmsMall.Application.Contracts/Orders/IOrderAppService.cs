using Volo.Abp.Application.Services;

namespace Yuri.ArmsMall.Orders;

/// <summary>
/// 
/// </summary>
public interface IOrderAppService : IApplicationService
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<(int, List<OrderDto>)> GetPageListAsync();
}
