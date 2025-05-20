using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Yuri.ArmsMall.Commons;

/// <summary>
/// 
/// </summary>
public class GlobalExceptionFilter : IExceptionFilter
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    public void OnException(ExceptionContext context)
    {
        var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<GlobalExceptionFilter>>();
        logger.LogError(context.Exception, "全局异常: {TraceId}", context.HttpContext.TraceIdentifier);
        context.ExceptionHandled = true;
        context.Result = ApiResponse.Error(code: 500, message: "服务器内部错误", errors: new[] { context.Exception.Message });
    }
}
