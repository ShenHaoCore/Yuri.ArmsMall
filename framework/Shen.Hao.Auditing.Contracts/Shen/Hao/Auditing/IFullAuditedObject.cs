namespace Shen.Hao.Auditing;

/// <summary>
/// 完整审计对象接口
/// </summary>
public interface IFullAuditedObject : IAuditedObject, IDeletionAuditedObject
{

}

/// <summary>
/// 完整审计对象接口
/// </summary>
/// <typeparam name="TUser">用户类型</typeparam>
public interface IFullAuditedObject<TUser> : IFullAuditedObject, IAuditedObject<TUser>, IDeletionAuditedObject<TUser>
{

}

