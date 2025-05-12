using System.Diagnostics.CodeAnalysis;
using Yuri.ArmsMall.Common.Entities;
using Yuri.ArmsMall.EntityFrameworkCore;

namespace Yuri.ArmsMall.Common.Repositories;

/// <inheritdoc cref="IEntityFrameworkCoreRepository{TEntity}"/>
public class EntityFrameworkCoreRepository<TDbContext, TEntity> : BasicRepository<TEntity>, IEntityFrameworkCoreRepository<TEntity> where TDbContext : IEntityFrameworkCoreDbContext where TEntity : class, IEntity
{
    private readonly IDbContextProvider<TDbContext> _dbContext;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="dbContext"></param>
    public EntityFrameworkCoreRepository(IDbContextProvider<TDbContext> dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    protected virtual Task<TDbContext> GetDbContextAsync()
    {
        return _dbContext.GetDbContextAsync();
    }

    /// <inheritdoc/>
    public async override Task<TEntity> InsertAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default)
    {
        var dbContext = await GetDbContextAsync();
        var savedEntity = (await dbContext.Set<TEntity>().AddAsync(entity)).Entity;
        return savedEntity;
    }

    /// <inheritdoc/>
    public async override Task InsertManyAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default)
    {
        var entityArray = entities.ToArray();
        if (entityArray == null || !entityArray.Any()) { return; }
        var dbContext = await GetDbContextAsync();
        await dbContext.Set<TEntity>().AddRangeAsync(entityArray, cancellationToken);
    }
}
