using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Yuri.ArmsMall.EntityFrameworkCore;

namespace Yuri.ArmsMall;

/// <summary>
/// 
/// </summary>
[DependsOn(typeof(ArmsMallDomainModule))]
public class ArmsMallEntityFrameworkCoreModule : AbpModule
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
        context.Services.AddAbpDbContext<ArmsMallDbContext>(options => { options.AddDefaultRepositories(includeAllEntities: true); });
        Configure<AbpDbContextOptions>(options => { options.UseSqlServer(); });
    }
}