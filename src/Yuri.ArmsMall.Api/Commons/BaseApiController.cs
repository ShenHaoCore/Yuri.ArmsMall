using Microsoft.AspNetCore.Mvc;

namespace Yuri.ArmsMall.Commons;

/// <summary>
/// 
/// </summary>
[ApiController]
[Route("api/v{version:apiVersion}/[controller]/[action]")]
public class BaseApiController : ControllerBase
{
    /// <summary>
    /// 成功
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    protected IActionResult Success<T>(T data, string message = "成功")
    {
        return ApiResponse<T>.Success(data, message);
    }

    /// <summary>
    /// 错误
    /// </summary>
    /// <param name="code"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    protected IActionResult Error(int code, string message)
    {
        return ApiResponse.Error(code, message);
    }
}
