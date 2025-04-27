namespace Shen.Hao;

/// <summary>
/// 软删除接口
/// </summary>
public interface ISoftDelete
{
    /// <summary>
    /// 删除标记
    /// </summary>
    bool IsDeleted { get; }
}
