using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Yuri.ArmsMall.Common.Entities;

namespace Yuri.ArmsMall.Common.Repositories;

/// <summary>
/// 只读仓储
/// </summary>
public interface IReadOnlyRepository<TEntity> : IRepository where TEntity : class, IEntity
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<IQueryable<TEntity>> WithDetailsAsync(); //TODO: CancellationToken

    /// <summary>
    /// 
    /// </summary>
    /// <param name="propertySelectors"></param>
    /// <returns></returns>
    Task<IQueryable<TEntity>> WithDetailsAsync(params Expression<Func<TEntity, object>>[] propertySelectors); //TODO: CancellationToken

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<IQueryable<TEntity>> GetQueryableAsync(); //TODO: CancellationToken

    /// <summary>
    /// 获取所有实体的列表
    /// </summary>
    /// <param name="includeDetails">设置为 true 以包括此实体的所有子项</param>
    /// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /> 用于向任务传递取消信号</param>
    /// <returns></returns>
    Task<List<TEntity>> GetListAsync(bool includeDetails = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取所有实体的总数
    /// </summary>
    /// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /> 用于向任务传递取消信号</param>
    /// <returns></returns>
    Task<long> GetCountAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// 获取分页数据
    /// </summary>
    /// <param name="pageIndex">页码（从 0 开始）</param>
    /// <param name="pageSize"></param>
    /// <param name="sorting"></param>
    /// <param name="includeDetails"></param>
    /// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /> 用于向任务传递取消信号</param>
    /// <returns></returns>
    Task<List<TEntity>> GetPagedListAsync(int pageIndex, int pageSize, string sorting, bool includeDetails = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="predicate"></param>
    /// <param name="includeDetails"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<List<TEntity>> GetListAsync([NotNull] Expression<Func<TEntity, bool>> predicate, bool includeDetails = false, CancellationToken cancellationToken = default);
}

/// <summary>
/// 只读仓储
/// </summary>
public interface IReadOnlyRepository<TEntity, TKey> : IReadOnlyRepository<TEntity> where TEntity : class, IEntity<TKey>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDetails"></param>
    /// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /> 用于向任务传递取消信号</param>
    /// <returns></returns>
    [return: NotNull]
    Task<TEntity> GetAsync(TKey id, bool includeDetails = true, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDetails"></param>
    /// <param name="cancellationToken"><see cref="T:System.Threading.CancellationToken" /> 用于向任务传递取消信号</param>
    /// <returns></returns>
    Task<TEntity?> FindAsync(TKey id, bool includeDetails = true, CancellationToken cancellationToken = default);
}
