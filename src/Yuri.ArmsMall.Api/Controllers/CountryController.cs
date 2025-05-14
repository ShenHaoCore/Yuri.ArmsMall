using Microsoft.AspNetCore.Mvc;
using Yuri.ArmsMall.Countries;

namespace Yuri.ArmsMall.Controllers;

/// <summary>
/// 
/// </summary>
[ApiController]
[Route("api/[controller]/[action]")]
public class CountryController : ControllerBase
{
    private readonly ICountryAppService _countryAppService;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="countryAppService"></param>
    public CountryController(ICountryAppService countryAppService)
    {
        _countryAppService = countryAppService;
    }

    /// <summary>
    /// 获取国家对象
    /// </summary>
    /// <returns></returns>
    [HttpGet("{id}")]
    [EndpointSummary("国家API")]
    [EndpointDescription("获取国家对象")]
    public async Task<IActionResult> Get(Guid id)
    {
        return Ok(await _countryAppService.GetAsync(id));
    }

    /// <summary>
    /// 获取国家分页
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [EndpointSummary("国家API")]
    [EndpointDescription("获取国家分页列表")]
    public async Task<IActionResult> GetPage()
    {
        (int count, List<CountryDto> list) = await _countryAppService.GetPageListAsync();
        return Ok(new { count, list });
    }
}
