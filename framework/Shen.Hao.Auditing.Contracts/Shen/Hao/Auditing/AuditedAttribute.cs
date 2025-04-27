namespace Shen.Hao.Auditing;

/// <summary>
/// 标记需要审计的类、方法或属性
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
public class AuditedAttribute : Attribute
{
}
