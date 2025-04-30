using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Yuri.ArmsMall.Common.Entities;

namespace Yuri.ArmsMall.Common.Repositories;

/// <inheritdoc cref="IBasicRepository{TEntity}"/>
public abstract class BasicRepository<TEntity> : IBasicRepository<TEntity> where TEntity : class, IEntity
{
    /// <inheritdoc/>
    public bool? IsChangeTrackingEnabled { get; protected set; }

    /// <summary>
    /// 
    /// </summary>
    protected BasicRepository() { }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    protected virtual Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    /// <inheritdoc/>
    public abstract Task<TEntity> InsertAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    public virtual async Task InsertManyAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default)
    {
        foreach (TEntity entity in entities) { await InsertAsync(entity, cancellationToken: cancellationToken); }
        if (autoSave) { await SaveChangesAsync(cancellationToken); }
    }

    /// <inheritdoc/>
    public abstract Task DeleteAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    public virtual async Task DeleteManyAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default)
    {
        foreach (TEntity entity in entities) { await DeleteAsync(entity, cancellationToken: cancellationToken); }
        if (autoSave) { await SaveChangesAsync(cancellationToken); }
    }

    /// <inheritdoc/>
    public abstract Task DeleteAsync([NotNull] Expression<Func<TEntity, bool>> predicate, bool autoSave = false, CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    public abstract Task DeleteDirectAsync([NotNull] Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    public abstract Task<TEntity> UpdateAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    public virtual async Task UpdateManyAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default)
    {
        foreach (TEntity entity in entities) { await UpdateAsync(entity, cancellationToken: cancellationToken); }
        if (autoSave) { await SaveChangesAsync(cancellationToken); }
    }

    /// <inheritdoc/>
    public abstract Task<long> GetCountAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    public abstract Task<TEntity> GetAsync([NotNull] Expression<Func<TEntity, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    public abstract Task<TEntity?> FindAsync([NotNull] Expression<Func<TEntity, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    public abstract Task<List<TEntity>> GetListAsync(bool includeDetails = false, CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    public abstract Task<List<TEntity>> GetListAsync([NotNull] Expression<Func<TEntity, bool>> predicate, bool includeDetails = false, CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    public abstract Task<List<TEntity>> GetPagedListAsync(int pageIndex, int pageSize, string sorting, bool includeDetails = false, CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    public virtual Task<IQueryable<TEntity>> WithDetailsAsync() => GetQueryableAsync();

    /// <inheritdoc/>
    public virtual Task<IQueryable<TEntity>> WithDetailsAsync(params Expression<Func<TEntity, object>>[] propertySelectors) => GetQueryableAsync();

    /// <inheritdoc/>
    public abstract Task<IQueryable<TEntity>> GetQueryableAsync();
}

/// <summary>
/// 
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TKey"></typeparam>
public abstract class BasicRepository<TEntity, TKey> : BasicRepository<TEntity>, IBasicRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
{
    /// <inheritdoc/>
    public virtual async Task DeleteAsync(TKey id, bool autoSave = false, CancellationToken cancellationToken = default)
    {
        var entity = await FindAsync(id, cancellationToken: cancellationToken);
        if (entity == null) { return; }
        await DeleteAsync(entity, autoSave, cancellationToken);
    }

    /// <inheritdoc/>
    public virtual async Task DeleteManyAsync([NotNull] IEnumerable<TKey> ids, bool autoSave = false, CancellationToken cancellationToken = default)
    {
        foreach (TKey id in ids) { await DeleteAsync(id, cancellationToken: cancellationToken); }
        if (autoSave) { await SaveChangesAsync(cancellationToken); }
    }

    /// <inheritdoc/>
    public abstract Task<TEntity> GetAsync(TKey id, bool includeDetails = true, CancellationToken cancellationToken = default);

    /// <inheritdoc/>
    public abstract Task<TEntity?> FindAsync(TKey id, bool includeDetails = true, CancellationToken cancellationToken = default);
}
