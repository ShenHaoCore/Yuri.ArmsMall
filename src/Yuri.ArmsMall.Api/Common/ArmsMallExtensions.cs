using Asp.Versioning;

namespace Yuri.ArmsMall.Common;

/// <summary>
/// 
/// </summary>
public static class ArmsMallExtensions
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
        return services;
    }

    /// <summary>
    /// 添加版本
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddOpenApiVersioning(this IServiceCollection services)
    {
        IApiVersioningBuilder builder = services.AddApiVersioning(options =>
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
        return services;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    /// <param name="apiVersioning"></param>
    /// <returns></returns>
    public static IHostApplicationBuilder AddDefaultOpenApi(this IHostApplicationBuilder builder, IApiVersioningBuilder? apiVersioning = default)
    {
        if (apiVersioning is not null)
        {

        }
        return builder;
    }
}
