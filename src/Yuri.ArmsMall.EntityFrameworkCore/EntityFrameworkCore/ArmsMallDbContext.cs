using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;

namespace Yuri.ArmsMall.EntityFrameworkCore;

/// <summary>
/// 
/// </summary>
[ConnectionStringName("Default")]
public class ArmsMallDbContext : DbContext
{
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
