using System.Diagnostics.CodeAnalysis;
using Yuri.ArmsMall.Domain.Entities;

namespace Yuri.ArmsMall.Domain.Repositories;

/// <summary>
/// 仓储接口
/// </summary>
public interface IRepository
{

}

/// <summary>
/// 仓储接口
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public interface IRepository<TEntity> : IRepository where TEntity : class, IEntity
{
    /// <summary>
    /// 插入实体
    /// </summary>
    /// <param name="entity">插入的实体</param>
    /// <param name="autoSave">自动保存</param>
    /// <param name="cancellationToken">等待任务完成时要观察<see cref="T:System.Threading.CancellationToken"/></param>
    /// <returns>实体</returns>
    [return: NotNull]
    Task<TEntity> InsertAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// 插入多个实体
    /// </summary>
    /// <param name="entities">要插入的实体</param>
    /// <param name="autoSave"></param>
    /// <param name="cancellationToken">等待任务完成时要观察<see cref="T:System.Threading.CancellationToken"/></param>
    /// <returns></returns>
    Task InsertManyAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default);
}

/// <summary>
/// 仓储接口
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TKey"></typeparam>
public interface IRepository<TEntity, TKey> : IRepository<TEntity> where TEntity : class, IEntity<TKey>
{

}