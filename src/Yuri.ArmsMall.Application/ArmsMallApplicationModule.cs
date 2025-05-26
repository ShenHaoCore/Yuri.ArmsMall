using Volo.Abp.AutoMapper;
using Volo.Abp.FluentValidation;
using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Yuri.ArmsMall.Countries;

namespace Yuri.ArmsMall;

/// <summary>
/// 
/// </summary>
[DependsOn(typeof(AbpAutoMapperModule))]
[DependsOn(typeof(AbpFluentValidationModule))]
[DependsOn(typeof(ArmsMallApplicationContractsModule))]
[DependsOn(typeof(ArmsMallDomainModule))]
public class ArmsMallApplicationModule : AbpModule
{
    /// <summary>
    /// 预配置服务
    /// </summary>
    /// <param name="context"></param>
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {

    }

    /// <summary>
    /// 配置服务
    /// </summary>
    /// <param name="context"></param>
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options => { options.AddMaps<ArmsMallApplicationModule>(); });
        Configure<AbpValidationOptions>(options => { });
    }
}
