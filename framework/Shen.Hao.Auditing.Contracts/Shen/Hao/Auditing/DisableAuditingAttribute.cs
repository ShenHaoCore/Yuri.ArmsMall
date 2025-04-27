namespace Shen.Hao.Auditing;

/// <summary>
/// 标记需要禁用审计的类、方法或属性
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
public class DisableAuditingAttribute : Attribute
{
}
