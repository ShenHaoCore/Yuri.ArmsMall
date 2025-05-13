using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Yuri.ArmsMall.Countries;

namespace Yuri.ArmsMall.EntityFrameworkCore;

/// <summary>
/// 
/// </summary>
[ConnectionStringName("ArmsMall")]
public class ArmsMallDbContext : AbpDbContext<ArmsMallDbContext>
{
    #region 实体
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Country> Countries { get; set; }
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
    }
}
