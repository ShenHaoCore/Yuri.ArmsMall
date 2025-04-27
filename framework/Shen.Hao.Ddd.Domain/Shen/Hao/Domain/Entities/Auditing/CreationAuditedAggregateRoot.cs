using Shen.Hao.Auditing;

namespace Shen.Hao.Domain.Entities.Auditing;

/// <summary>
/// 此类可用于简化聚合根的实现<see cref="ICreationAuditedObject"/>
/// </summary>
[Serializable]
public abstract class CreationAuditedAggregateRoot : AggregateRoot, ICreationAuditedObject
{
    /// <inheritdoc />
    public virtual DateTime CreationTime { get; protected set; }

    /// <inheritdoc />
    public virtual Guid? CreatorId { get; protected set; }
}

/// <summary>
/// 此类可用于简化聚合根的实现<see cref="ICreationAuditedObject"/>
/// </summary>
/// <typeparam name="TKey"></typeparam>
[Serializable]
public abstract class CreationAuditedAggregateRoot<TKey> : AggregateRoot<TKey>, ICreationAuditedObject
{
    /// <inheritdoc />
    public virtual DateTime CreationTime { get; protected set; }

    /// <inheritdoc />
    public virtual Guid? CreatorId { get; protected set; }

    /// <summary>
    /// 
    /// </summary>
    protected CreationAuditedAggregateRoot()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    protected CreationAuditedAggregateRoot(TKey id) : base(id)
    {

    }
}
