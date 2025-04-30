namespace Yuri.ArmsMall.Common.Repositories;

/// <summary>
/// 仓储接口
/// </summary>
public interface IRepository
{
    /// <summary>
    /// 是否启用更改跟踪
    /// </summary>
    bool? IsChangeTrackingEnabled { get; }
}
