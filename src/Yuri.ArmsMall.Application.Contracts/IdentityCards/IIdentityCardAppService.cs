using Volo.Abp.Application.Services;
using Yuri.ArmsMall.Countries;

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

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="id">ID</param>
    /// <param name="input">输入参数</param>
    Task UpdateAsync(Guid id, UpdateIdentityCardDto input);

    /// <summary>
    /// 获取列表
    /// </summary>
    /// <returns></returns>
    Task<List<IdentityCardDto>> GetListAsync();
}
