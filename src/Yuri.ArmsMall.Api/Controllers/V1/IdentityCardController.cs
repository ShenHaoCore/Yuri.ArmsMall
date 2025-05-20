using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Yuri.ArmsMall.Commons;
using Yuri.ArmsMall.Countries;
using Yuri.ArmsMall.IdentityCards;

namespace Yuri.ArmsMall.Controllers.V1;

/// <summary>
/// 身份证
/// </summary>
[ApiVersion(1.0)]
public class IdentityCardController : BaseApiController
{
    private readonly IIdentityCardAppService _identityCardAppService;

    /// <summary>
    /// 身份证
    /// </summary>
    /// <param name="identityCardAppService"></param>
    public IdentityCardController(IIdentityCardAppService identityCardAppService)
    {
        _identityCardAppService = identityCardAppService;
    }

    /// <summary>
    /// 创建身份证
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [EndpointSummary("创建API")]
    [EndpointDescription("创建身份证")]
    public async Task<IActionResult> CreateAsync([FromBody] CreateIdentityCardDto request)
    {
        return Success(await _identityCardAppService.CreateAsync(request));
    }

    /// <summary>
    /// 修改身份证
    /// </summary>
    /// <returns></returns>
    [HttpPut("{id}")]
    [EndpointSummary("修改API")]
    [EndpointDescription("修改身份证")]
    public async Task<IActionResult> UpdateAsync([Required][DefaultValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")] Guid id, [FromBody] UpdateIdentityCardDto request)
    {
        await _identityCardAppService.UpdateAsync(id, request);
        return Success("SUCCESS");
    }

    /// <summary>
    /// 获取身份证列表
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    [EndpointSummary("获取列表API")]
    [EndpointDescription("获取身份证列表")]
    public async Task<IActionResult> GetListAsync()
    {
        List<IdentityCardDto> list = await _identityCardAppService.GetListAsync();
        return Success(list);
    }
}
