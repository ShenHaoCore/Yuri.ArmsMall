using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Yuri.ArmsMall.Common.Entities;

namespace Yuri.ArmsMall.Common.Repositories;

/// <summary>
/// 基础仓储
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public interface IBasicRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class, IEntity
{
    /// <summary>
    /// 插入
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="autoSave">设置为 true 可自动保存对数据库的更改</param>
    /// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /> 用于向任务传递取消信号</param>
    /// <returns></returns>
    [return: NotNull]
    Task<TEntity> InsertAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量插入
    /// </summary>
    /// <param name="entities"></param>
    /// <param name="autoSave">设置为 true 可自动保存对数据库的更改</param>
    /// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /> 用于向任务传递取消信号</param>
    /// <returns></returns>
    Task InsertManyAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// 更新
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="autoSave">设置为 true 可自动保存对数据库的更改</param>
    /// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /> 用于向任务传递取消信号</param>
    /// <returns></returns>
    [return: NotNull]
    Task<TEntity> UpdateAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量更新
    /// </summary>
    /// <param name="entities"></param>
    /// <param name="autoSave">设置为 true 可自动保存对数据库的更改</param>
    /// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /> 用于向任务传递取消信号</param>
    /// <returns></returns>
    Task UpdateManyAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="autoSave">设置为 true 可自动保存对数据库的更改</param>
    /// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /> 用于向任务传递取消信号</param>
    /// <returns></returns>
    Task DeleteAsync([NotNull] TEntity entity, bool autoSave = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// 批量删除
    /// </summary>
    /// <param name="entities"></param>
    /// <param name="autoSave">设置为 true 可自动保存对数据库的更改</param>
    /// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /> 用于向任务传递取消信号</param>
    /// <returns></returns>
    Task DeleteManyAsync([NotNull] IEnumerable<TEntity> entities, bool autoSave = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="includeDetails"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<TEntity?> FindAsync([NotNull] Expression<Func<TEntity, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="includeDetails"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<TEntity> GetAsync([NotNull] Expression<Func<TEntity, bool>> predicate, bool includeDetails = true, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="autoSave"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DeleteAsync([NotNull] Expression<Func<TEntity, bool>> predicate, bool autoSave = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// 直接删除
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task DeleteDirectAsync([NotNull] Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
}

/// <summary>
/// 基础仓储
/// </summary>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TKey"></typeparam>
public interface IBasicRepository<TEntity, TKey> : IBasicRepository<TEntity>, IReadOnlyRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
{
    /// <summary>
    /// 根据主键删除
    /// </summary>
    /// <param name="id"></param>
    /// <param name="autoSave">设置为 true 可自动保存对数据库的更改</param>
    /// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /> 用于向任务传递取消信号</param>
    /// <returns></returns>
    Task DeleteAsync(TKey id, bool autoSave = false, CancellationToken cancellationToken = default);  //TODO: Return true if deleted

    /// <summary>
    /// 根据主键批量删除
    /// </summary>
    /// <param name="ids"></param>
    /// <param name="autoSave">设置为 true 可自动保存对数据库的更改</param>
    /// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /> 用于向任务传递取消信号</param>
    /// <returns></returns>
    Task DeleteManyAsync([NotNull] IEnumerable<TKey> ids, bool autoSave = false, CancellationToken cancellationToken = default);
}
