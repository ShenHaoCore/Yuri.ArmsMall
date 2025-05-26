
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

    /// <inheritdoc/>
    public async Task<OrderDto> CreateAsync()
    {
        await Task.CompletedTask;
        return new OrderDto();
    }

    /// <inheritdoc/>
    public async Task DeleteAsync(Guid id)
    {
        await Task.CompletedTask;
    }

    /// <inheritdoc/>
    public async Task<(int, List<OrderDto>)> GetPagedAsync()
    {
        await Task.CompletedTask;
        return (0, []);
    }
}
