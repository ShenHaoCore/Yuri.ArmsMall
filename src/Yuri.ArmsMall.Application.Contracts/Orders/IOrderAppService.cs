using Volo.Abp.Application.Services;

namespace Yuri.ArmsMall.Orders;

/// <summary>
/// 
/// </summary>
public interface IOrderAppService : IApplicationService
{
    /// <summary>
    /// 创建
    /// </summary>
    /// <returns></returns>
    Task<OrderDto> CreateAsync();

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteAsync(Guid id);

    /// <summary>
    /// 获取分页
    /// </summary>
    /// <returns></returns>
    Task<(int, List<OrderDto>)> GetPagedAsync();
}
