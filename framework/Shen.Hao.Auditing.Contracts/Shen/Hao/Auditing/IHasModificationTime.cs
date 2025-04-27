namespace Shen.Hao.Auditing;

/// <summary>
/// 修改时间属性接口
/// </summary>
public interface IHasModificationTime
{
    /// <summary>
    /// 最后修改时间
    /// </summary>
    DateTime? LastModificationTime { get; }
}
