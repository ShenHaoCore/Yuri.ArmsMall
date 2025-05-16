using Asp.Versioning.ApiExplorer;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.OpenApi.Models;

namespace Yuri.ArmsMall.Common;

/// <summary>
/// 
/// </summary>
public sealed class ApiDocumentTransformer : IOpenApiDocumentTransformer
{
    private readonly IApiVersionDescriptionProvider _provider;

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="provider"></param>
    public ApiDocumentTransformer(IApiVersionDescriptionProvider provider)
    {
        _provider = provider;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="document"></param>
    /// <param name="context"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task TransformAsync(OpenApiDocument document, OpenApiDocumentTransformerContext context, CancellationToken cancellationToken)
    {
        document.Info = new() { Title = $"尤里武器商城", Version = context.DocumentName, Description = $"尤里武器商城相关接口" };
        document.Info.Contact = new OpenApiContact { Name = "Shen Hao", Email = "shenhao@by56.com" };
        return Task.CompletedTask;
    }
}
