using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Yuri.ArmsMall.Countries;
using Yuri.ArmsMall.IdentityCards;

namespace Yuri.ArmsMall.EntityFrameworkCore;

/// <summary>
/// 
/// </summary>
[ConnectionStringName("ArmsMall")]
public class ArmsMallDbContext : AbpDbContext<ArmsMallDbContext>
{
    #region 实体
    public DbSet<Country> Countries { get; set; }
    public DbSet<IdentityCard> IdentityCards { get; set; }
    #endregion

    /// <summary>
    /// 
    /// </summary>
    /// <param name="options"></param>
    public ArmsMallDbContext(DbContextOptions<ArmsMallDbContext> options) : base(options)
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Configure your own tables/entities inside here */
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
