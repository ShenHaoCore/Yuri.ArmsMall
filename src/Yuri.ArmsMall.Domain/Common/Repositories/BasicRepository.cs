using System.Diagnostics.CodeAnalysis;
using Yuri.ArmsMall.Common.Entities;

namespace Yuri.ArmsMall.Common.Repositories;

/// <summary>
/// 基础仓储
/// </summary>
/// <typeparam name="TEntity">实体类型</typeparam>
public abstract class BasicRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
{
    /// <inheritdoc />
    public abstract Task<TEntity> InsertAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    public virtual async Task InsertManyAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default)
    {
        foreach (var entity in entities)
        {
            await InsertAsync(entity, cancellationToken: cancellationToken);
        }
    }
}

/// <summary>
/// 基础仓储
/// </summary>
/// <typeparam name="TEntity">实体类型</typeparam>
/// <typeparam name="TKey">主键类型</typeparam>
public abstract class BasicRepository<TEntity, TKey> : BasicRepository<TEntity>, IRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
{

}
