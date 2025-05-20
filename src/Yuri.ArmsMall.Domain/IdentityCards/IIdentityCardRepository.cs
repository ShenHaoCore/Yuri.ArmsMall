using Volo.Abp.Domain.Repositories;

namespace Yuri.ArmsMall.IdentityCards;

/// <summary>
/// 身份证
/// </summary>
public interface IIdentityCardRepository : IRepository<IdentityCard, Guid>
{

}
