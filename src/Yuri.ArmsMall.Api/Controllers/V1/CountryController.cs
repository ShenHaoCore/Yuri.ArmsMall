using Microsoft.AspNetCore.Mvc;
using Yuri.ArmsMall.Countries;

namespace Yuri.ArmsMall.Controllers.V1;

[Route("api/[controller]")]
[ApiController]
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
    /// 获取
    /// </summary>
    /// <returns></returns>
    [HttpGet("{id}")]
    [EndpointSummary("获取国家API")]
    [EndpointDescription("获取国家")]
    public async Task<IActionResult> Get(Guid id)
    {
        return Ok(await _countryAppService.GetAsync(id));
    }
}
