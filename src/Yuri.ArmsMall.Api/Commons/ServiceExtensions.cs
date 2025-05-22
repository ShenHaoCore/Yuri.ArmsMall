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
    public static IServiceCollection AddOpenApiVersioning(this IServiceCollection services)
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

        foreach (var version in ApiVersionConsts.All)
        {
            services.AddOpenApi($"v{version}", option =>
            {
                option.AddDocumentTransformer((document, context, cancellationToken) =>
                {
                    document.Info = new() { Title = $"尤里武器商城 - V{version}", Version = $"v{version}", Description = $"尤里武器商城相关接口" };
                    document.Info.Contact = new OpenApiContact { Name = "ShenHao", Email = "shenhao@by56.com" };
                    return Task.CompletedTask;
                });
            });
        }

        return services;
    }
}
