namespace Shen.Hao.Auditing;

/// <summary>
/// 创建审计对象接口
/// </summary>
public interface ICreationAuditedObject : IHasCreationTime, IMayHaveCreator
{

}

/// <summary>
/// 创建审计对象接口
/// </summary>
/// <typeparam name="TCreator">创建人</typeparam>
public interface ICreationAuditedObject<TCreator> : ICreationAuditedObject, IMayHaveCreator<TCreator>
{

}