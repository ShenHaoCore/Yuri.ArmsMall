namespace Shen.Hao.Domain.Entities;

/// <inheritdoc cref="IEntity" />
[Serializable]
public abstract class Entity : IEntity
{
    /// <inheritdoc/>
    public abstract object?[] GetKeys();

    /// <summary>
    /// 返回一个表示当前对象的字符串。
    /// </summary>
    /// <returns>表示当前对象的字符串</returns>
    public override string ToString()
    {
        return $"[ENTITY: {GetType().Name}] Keys = {GetKeys().JoinAsString(", ")}";
    }
}

/// <inheritdoc cref="IEntity{TKey}" />
[Serializable]
public abstract class Entity<TKey> : Entity, IEntity<TKey>
{
    /// <inheritdoc/>
    public virtual TKey Id { get; protected set; } = default!;

    /// <summary>
    /// 
    /// </summary>
    protected Entity()
    {

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    protected Entity(TKey id)
    {
        Id = id;
    }

    /// <inheritdoc/>
    public override object?[] GetKeys()
    {
        return [Id];
    }

    /// <inheritdoc/>
    public override string ToString()
    {
        return $"[ENTITY: {GetType().Name}] Id = {Id}";
    }
}
