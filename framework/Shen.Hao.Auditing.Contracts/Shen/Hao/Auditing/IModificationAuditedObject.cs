namespace Shen.Hao.Auditing;

/// <summary>
/// 修改审计对象接口
/// </summary>
public interface IModificationAuditedObject : IHasModificationTime
{
    /// <summary>
    /// 最后修改用户ID
    /// </summary>
    Guid? LastModifierId { get; }
}

/// <summary>
/// 修改审计对象接口
/// </summary>
/// <typeparam name="TUser">用户类型</typeparam>
public interface IModificationAuditedObject<TUser> : IModificationAuditedObject
{
    /// <summary>
    /// 最后修改用户。
    /// </summary>
    TUser? LastModifier { get; }
}
