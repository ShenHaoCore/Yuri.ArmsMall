using Microsoft.AspNetCore.Mvc;

namespace Yuri.ArmsMall.Commons;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public class ApiResponse<T>
{
    /// <summary>
    /// 是否成功
    /// </summary>
    public bool IsSuccess { get; set; }

    /// <summary>
    /// 业务状态码
    /// </summary>
    public int Code { get; set; }

    /// <summary>
    /// 操作结果信息
    /// </summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// 返回的数据
    /// </summary>
    public T? Data { get; set; }

    /// <summary>
    /// 响应生成时间（UTC 时间）
    /// </summary>
    public DateTime Timestamp { get; set; }

    /// <summary>
    /// 错误详情（如验证错误或业务异常）
    /// </summary>
    public string[]? Errors { get; set; }

    /// <summary>
    /// 请求唯一标识，用于日志追踪
    /// </summary>
    public string TraceId { get; set; } = string.Empty;

    /// <summary>
    /// 成功
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public static IActionResult Success(T data, string message = "成功")
    {
        var response = new ApiResponse<T> { IsSuccess = true, Code = 200, Message = message, Data = data, Timestamp = DateTime.UtcNow, TraceId = Guid.NewGuid().ToString() };
        return new ObjectResult(response) { StatusCode = 200 };
    }

    /// <summary>
    /// 错误
    /// </summary>
    /// <param name="code"></param>
    /// <param name="message"></param>
    /// <returns></returns>
    public static IActionResult Error(int code, string message, string[]? errors = null)
    {
        var response = new ApiResponse<object> { IsSuccess = false, Code = code, Message = message, Data = null, Timestamp = DateTime.UtcNow, Errors = errors, TraceId = Guid.NewGuid().ToString() };
        return new ObjectResult(response) { StatusCode = 200 };
    }
}

/// <summary>
/// 
/// </summary>
public class ApiResponse : ApiResponse<object> { }
