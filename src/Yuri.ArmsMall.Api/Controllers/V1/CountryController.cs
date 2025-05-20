using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Yuri.ArmsMall.Commons;
using Yuri.ArmsMall.Countries;

namespace Yuri.ArmsMall.Controllers.V1;

/// <summary>
/// 国家
/// </summary>
[ApiVersion(1.0)]
public class CountryController : BaseApiController
{
    private readonly ICountryAppService _countryAppService;

    /// <summary>
    /// 国家
    /// </summary>
    /// <param name="countryAppService"></param>
    public CountryController(ICountryAppService countryAppService)
    {
        _countryAppService = countryAppService;
    }

    /// <summary>
    /// 创建国家
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [EndpointSummary("创建API")]
    [EndpointDescription("创建国家")]
    public async Task<IActionResult> CreateAsync([FromBody] CreateCountryDto request)
    {
        return Success(await _countryAppService.CreateAsync(request));
    }

    /// <summary>
    /// 删除国家
    /// </summary>
    /// <returns></returns>
    [HttpDelete]
    [EndpointSummary("删除API")]
    [EndpointDescription("删除国家")]
    public async Task<IActionResult> DeleteAsync([Required][DefaultValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")] Guid id)
    {
        await _countryAppService.DeleteAsync(id);
        return Success("SUCCESS");
    }

    /// <summary>
    /// 修改国家
    /// </summary>
    /// <returns></returns>
    [HttpPut("{id}")]
    [EndpointSummary("修改API")]
    [EndpointDescription("修改国家")]
    public async Task<IActionResult> UpdateAsync([Required][DefaultValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")] Guid id, [FromBody] UpdateCountryDto request)
    {
        await _countryAppService.UpdateAsync(id, request);
        return Success("SUCCESS");
    }

    /// <summary>
    /// 获取国家对象
    /// </summary>
    /// <returns></returns>
    [HttpGet("{id}")]
    [EndpointSummary("获取对象API")]
    [EndpointDescription("获取国家对象")]
    public async Task<IActionResult> GetAsync([Required][DefaultValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")] Guid id)
    {
        return Success(await _countryAppService.GetAsync(id));
    }

    /// <summary>
    /// 获取国家列表
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [EndpointSummary("获取列表API")]
    [EndpointDescription("获取国家列表")]
    public async Task<IActionResult> GetListAsync()
    {
        List<CountryDto> list = await _countryAppService.GetListAsync();
        return Success(list);
    }

    /// <summary>
    /// 获取国家分页列表
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [EndpointSummary("获取分页API")]
    [EndpointDescription("获取国家分页列表")]
    public async Task<IActionResult> GetPageListAsync()
    {
        (int count, List<CountryDto> list) = await _countryAppService.GetPageListAsync();
        return Success(new { count, list });
    }
}
