namespace Shen.Hao.Domain.Entities;

/// <inheritdoc cref="IAggregateRoot" />
[Serializable]
public abstract class BasicAggregateRoot: Entity, IAggregateRoot
{

}

/// <inheritdoc cref="IAggregateRoot{TKey}" />
[Serializable]
public abstract class BasicAggregateRoot<TKey> : Entity<TKey>, IAggregateRoot<TKey>
{
    /// <summary>
    /// 
    /// </summary>
    protected BasicAggregateRoot()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    protected BasicAggregateRoot(TKey id) : base(id)
    {

    }
}
