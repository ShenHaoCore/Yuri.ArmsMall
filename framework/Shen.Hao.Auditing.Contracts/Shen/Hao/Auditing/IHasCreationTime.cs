namespace Shen.Hao.Auditing;

/// <summary>
/// 创建时间属性接口
/// </summary>
public interface IHasCreationTime
{
    /// <summary>
    /// 创建时间
    /// </summary>
    DateTime CreationTime { get; }
}
