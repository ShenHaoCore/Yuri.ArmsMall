using Volo.Abp.Application.Services;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public interface ICountryAppService : IApplicationService
{
    /// <summary>
    /// 创建
    /// </summary>
    /// <param name="input">输入参数</param>
    /// <returns></returns>
    Task<CountryDto> CreateAsync(CreateCountryDto input);

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteAsync(Guid id);

    /// <summary>
    /// 修改
    /// </summary>
    /// <param name="id">ID</param>
    /// <param name="input">输入参数</param>
    Task UpdateAsync(Guid id, UpdateCountryDto input);

    /// <summary>
    /// 获取实体
    /// </summary>
    /// <param name="id">ID</param>
    /// <returns></returns>
    Task<CountryDto> GetAsync(Guid id);

    /// <summary>
    /// 获取列表
    /// </summary>
    /// <returns></returns>
    Task<List<CountryDto>> GetListAsync();

    /// <summary>
    /// 获取分页
    /// </summary>
    /// <returns></returns>
    Task<(int, List<CountryDto>)> GetPageListAsync();
}
