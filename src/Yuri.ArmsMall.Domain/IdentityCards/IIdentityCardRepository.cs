using Volo.Abp.Domain.Repositories;
using Yuri.ArmsMall.Countries;

namespace Yuri.ArmsMall.IdentityCards;

/// <summary>
/// 身份证仓储
/// </summary>
public interface IIdentityCardRepository : IRepository<IdentityCard, Guid>
{
    /// <summary>
    /// 获取列表
    /// </summary>
    /// <returns></returns>
    Task<List<IdentityCard>> GetListAsync();

    /// <summary>
    /// 获取分页
    /// </summary>
    /// <returns></returns>
    Task<(int, List<IdentityCard>)> GetPagedAsync(int skipCount, int maxResultCount, string sorting, string? filter = null);
}
