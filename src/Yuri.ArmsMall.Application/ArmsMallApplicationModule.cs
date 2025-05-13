using Volo.Abp.Modularity;

namespace Yuri.ArmsMall;

/// <summary>
/// 
/// </summary>
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

    }
}
