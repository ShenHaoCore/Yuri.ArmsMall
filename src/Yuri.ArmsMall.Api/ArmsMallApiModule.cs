using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Yuri.ArmsMall;

/// <summary>
/// 
/// </summary>
[DependsOn(typeof(AbpAutofacModule))]
[DependsOn(typeof(ArmsMallApplicationModule))]
[DependsOn(typeof(ArmsMallEntityFrameworkCoreModule))]
public class ArmsMallApiModule : AbpModule
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
