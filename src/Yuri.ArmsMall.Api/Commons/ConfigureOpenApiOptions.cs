using Asp.Versioning.ApiExplorer;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.Extensions.Options;

namespace Yuri.ArmsMall.Commons;

/// <summary>
/// 
/// </summary>
public class ConfigureOpenApiOptions : IConfigureOptions<OpenApiOptions>
{
    private readonly IApiVersionDescriptionProvider provider;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="provider"></param>
    public ConfigureOpenApiOptions(IApiVersionDescriptionProvider provider)
    {
        this.provider = provider;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="options"></param>
    public void Configure(OpenApiOptions options)
    {
        foreach (ApiVersionDescription description in provider.ApiVersionDescriptions)
        {

        }
    }
}
