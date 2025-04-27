namespace Shen.Hao.Auditing;

/// <summary>
/// 删除审计对象接口
/// </summary>
public interface IDeletionAuditedObject : IHasDeletionTime
{
    /// <summary>
    /// 删除人的ID
    /// </summary>
    Guid? DeleterId { get; }
}

/// <summary>
/// 删除审计对象接口
/// </summary>
/// <typeparam name="TUser">用户类型</typeparam>
public interface IDeletionAuditedObject<TUser> : IDeletionAuditedObject
{
    /// <summary>
    /// 删除人
    /// </summary>
    TUser? Deleter { get; }
}
