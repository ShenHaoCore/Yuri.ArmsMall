using Volo.Abp.Application.Services;

namespace Yuri.ArmsMall.IdentityCards;

/// <summary>
/// 
/// </summary>
public interface IIdentityCardAppService : IApplicationService
{
    /// <summary>
    /// 创建
    /// </summary>
    /// <param name="input">输入参数</param>
    /// <returns></returns>
    Task<IdentityCardDto> CreateAsync(CreateIdentityCardDto input);
}
