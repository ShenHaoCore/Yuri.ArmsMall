using Asp.Versioning;
using Microsoft.OpenApi.Models;

namespace Yuri.ArmsMall.Commons;

/// <summary>
/// 
/// </summary>
public static class ServiceExtensions
{
    /// <summary>
    /// 添加版本
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddAspVersioning(this IServiceCollection services)
    {
        services.AddApiVersioning(options =>
        {
            options.DefaultApiVersion = new ApiVersion(1, 0);
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.ReportApiVersions = true;
            options.ApiVersionReader = ApiVersionReader.Combine(
                new UrlSegmentApiVersionReader(),
                new HeaderApiVersionReader("X-API-VERSION"),
                new MediaTypeApiVersionReader("VER")
                );
        }).AddMvc().AddApiExplorer(options =>
        {
            options.GroupNameFormat = "'v'VVV";
            options.SubstituteApiVersionInUrl = true;
        });
        services.AddOpenApi("v1", option =>
        {
            option.AddDocumentTransformer((document, context, cancellationToken) =>
            {
                document.Info = new() { Title = $"尤里武器商城 - V1", Version = "v1", Description = $"尤里武器商城相关接口" };
                document.Info.Contact = new OpenApiContact { Name = "ShenHao", Email = "shenhao@by56.com" };
                return Task.CompletedTask;
            });
        });
        services.AddOpenApi("v2", option =>
        {
            option.AddDocumentTransformer((document, context, cancellationToken) =>
            {
                document.Info = new() { Title = $"尤里武器商城 - V2", Version = "v2", Description = $"尤里武器商城相关接口" };
                document.Info.Contact = new OpenApiContact { Name = "ShenHao", Email = "shenhao@by56.com" };
                return Task.CompletedTask;
            });
        });

        return services;
    }
}
