namespace Shen.Hao.Domain.Entities;

/// <summary>
/// 定义聚合根，它的主键可能不是“Id”也可能有复合主键。<br />
/// 尽可能使用<see cref="IAggregateRoot{TKey}"/>以便更好地集成到框架中的存储库和其他结构。
/// </summary>
public interface IAggregateRoot : IEntity
{

}

/// <summary>
/// 使用具有“Id”属性的单个主键定义聚合根。
/// </summary>
/// <typeparam name="TKey">实体主键的类型</typeparam>
public interface IAggregateRoot<TKey> : IEntity<TKey>, IAggregateRoot
{

}
