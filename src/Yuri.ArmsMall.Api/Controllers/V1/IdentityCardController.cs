using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Yuri.ArmsMall.Commons;
using Yuri.ArmsMall.IdentityCards;

namespace Yuri.ArmsMall.Controllers.V1;

/// <summary>
/// 身份证
/// </summary>
[ApiVersion(ApiVersionConsts.V1)]
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
    /// <param name="request">请求</param>
    /// <returns></returns>
    [HttpPost]
    [EndpointSummary("创建API")]
    [EndpointDescription("创建身份证")]
    public async Task<IActionResult> CreateAsync([FromBody] CreateIdentityCardDto request)
    {
        return Success(await _identityCardAppService.CreateAsync(request));
    }

    /// <summary>
    /// 删除身份证
    /// </summary>
    /// <param name="id">ID</param>
    /// <returns></returns>
    [HttpDelete]
    [EndpointSummary("删除API")]
    [EndpointDescription("删除身份证")]
    public async Task<IActionResult> DeleteAsync([Required][DefaultValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")] Guid id)
    {
        await _identityCardAppService.DeleteAsync(id);
        return Success("SUCCESS");
    }

    /// <summary>
    /// 修改身份证
    /// </summary>
    /// <param name="id">ID</param>
    /// <param name="request">请求</param>
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
    /// 获取身份证对象
    /// </summary>
    /// <param name="id">ID</param>
    /// <returns></returns>
    [HttpGet("{id}")]
    [EndpointSummary("获取对象API")]
    [EndpointDescription("获取身份证对象")]
    public async Task<IActionResult> GetAsync([Required][DefaultValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")] Guid id)
    {
        return Success(await _identityCardAppService.GetAsync(id));
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
