﻿using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Yuri.ArmsMall.Commons;
using Yuri.ArmsMall.Hubs;

namespace Yuri.ArmsMall;

/// <summary>
/// 
/// </summary>
[DependsOn(typeof(AbpAutofacModule))]
[DependsOn(typeof(AbpAspNetCoreMvcModule))]
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
        Configure<AbpAspNetCoreMvcOptions>(options => { options.ConventionalControllers.Create(typeof(ArmsMallApplicationModule).Assembly); });
        context.Services.AddControllers(options => { options.Filters.Add<GlobalExceptionFilter>(); });
        context.Services.AddSignalR();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var env = context.GetEnvironment();
        var app = context.GetApplicationBuilder();
        if (env.IsDevelopment()) { app.UseDeveloperExceptionPage(); }
        app.UseRouting();
        app.UseEndpoints(endpoints => { endpoints.MapHub<ChatHub>("/ChatHub"); });
        app.UseHttpsRedirection();
        app.UseAuthorization();
    }
}
