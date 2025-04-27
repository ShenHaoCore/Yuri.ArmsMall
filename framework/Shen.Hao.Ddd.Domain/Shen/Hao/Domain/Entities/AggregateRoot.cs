using Shen.Hao.Auditing;

namespace Shen.Hao.Domain.Entities;

/// <inheritdoc cref="BasicAggregateRoot" />
[Serializable]
public abstract class AggregateRoot : BasicAggregateRoot
{
    /// <summary>
    /// 
    /// </summary>
    [DisableAuditing]
    public virtual string ConcurrencyStamp { get; set; }

    /// <summary>
    /// 
    /// </summary>
    protected AggregateRoot()
    {
        ConcurrencyStamp = Guid.NewGuid().ToString("N");
    }
}

/// <inheritdoc cref="BasicAggregateRoot{TKey}" />
[Serializable]
public abstract class AggregateRoot<TKey> : BasicAggregateRoot<TKey>
{
    /// <summary>
    /// 
    /// </summary>
    [DisableAuditing]
    public virtual string ConcurrencyStamp { get; set; }

    /// <summary>
    /// 
    /// </summary>
    protected AggregateRoot()
    {
        ConcurrencyStamp = Guid.NewGuid().ToString("N");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    protected AggregateRoot(TKey id) : base(id)
    {
        ConcurrencyStamp = Guid.NewGuid().ToString("N");
    }
}
