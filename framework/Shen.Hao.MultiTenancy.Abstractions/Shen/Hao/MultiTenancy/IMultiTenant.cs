namespace Shen.Hao.MultiTenancy;

/// <summary>
/// 
/// </summary>
public interface IMultiTenant
{
    /// <summary>
    /// 相关租户的“Id”
    /// </summary>
    Guid? TenantId { get; }
}
