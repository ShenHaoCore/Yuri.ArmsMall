namespace Yuri.ArmsMall.Domain.Entities;

/// <summary>
/// 定义实体（多主键或单主键）
/// </summary>
public interface IEntity
{

}

/// <summary>
/// 定义实体（主键为Id）
/// </summary>
/// <typeparam name="TKey">主键类型</typeparam>
public interface IEntity<TKey> : IEntity
{
    /// <summary>
    /// 标识
    /// </summary>
    TKey Id { get; }
}
