namespace Shen.Hao.Domain.Entities;

/// <summary>
/// 定义实体，它的主键可能不是“Id”也可能有复合主键。<br />
/// 尽可能使用<see cref="IEntity{TKey}"/>以便更好地集成到框架中的存储库和其他结构。
/// </summary>
public interface IEntity
{
    /// <summary>
    /// 返回此实体的有序键数组。
    /// </summary>
    /// <returns></returns>
    object?[] GetKeys();
}

/// <summary>
/// 使用具有“Id”属性的单个主键定义实体。
/// </summary>
/// <typeparam name="TKey">实体的主键类型</typeparam>
public interface IEntity<TKey> : IEntity
{
    /// <summary>
    /// 此实体的唯一标识符。
    /// </summary>
    TKey Id { get; }
}
