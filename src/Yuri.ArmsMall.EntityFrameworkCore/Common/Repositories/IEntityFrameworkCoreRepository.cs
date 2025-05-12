using Yuri.ArmsMall.Common.Entities;

namespace Yuri.ArmsMall.Common.Repositories;

/// <summary>
/// EntityFrameworkCore仓储
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public interface IEntityFrameworkCoreRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
{

}

/// <summary>
/// EntityFrameworkCore仓储
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TKey"></typeparam>
public interface IEntityFrameworkCoreRepository<TEntity, TKey> : IEntityFrameworkCoreRepository<TEntity>, IRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
{

}
