using Volo.Abp.Application.Dtos;
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

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="id">ID</param>
    /// <returns></returns>
    Task DeleteAsync(Guid id);

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="id">ID</param>
    /// <param name="input">输入参数</param>
    Task UpdateAsync(Guid id, UpdateIdentityCardDto input);

    /// <summary>
    /// 获取实体
    /// </summary>
    /// <param name="id">ID</param>
    /// <returns></returns>
    Task<IdentityCardDto> GetAsync(Guid id);

    /// <summary>
    /// 获取列表
    /// </summary>
    /// <returns></returns>
    Task<List<IdentityCardDto>> GetListAsync();

    /// <summary>
    /// 获取分页
    /// </summary>
    /// <returns></returns>
    Task<PagedResultDto<IdentityCardDto>> GetPagedAsync(GetIdentityCardPagedDto input);
}
