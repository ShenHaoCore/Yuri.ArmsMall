using Microsoft.EntityFrameworkCore;
using Yuri.ArmsMall.Orders;

namespace Yuri.ArmsMall.EntityFrameworkCore;

/// <summary>
/// 
/// </summary>
public class ArmsMallDbContext
{
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Order> Orders { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="options"></param>
    public ArmsMallDbContext()
    {

    }
}
