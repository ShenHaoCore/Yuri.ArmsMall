using Volo.Abp.Domain.Repositories;

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
}
