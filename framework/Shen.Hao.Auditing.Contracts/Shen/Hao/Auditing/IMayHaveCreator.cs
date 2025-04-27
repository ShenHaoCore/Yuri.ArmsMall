namespace Shen.Hao.Auditing;

/// <summary>
/// 可能有创建人接口
/// </summary>
public interface IMayHaveCreator
{
    /// <summary>
    /// 创建人ID
    /// </summary>
    Guid? CreatorId { get; }
}

/// <summary>
/// 可能有创建人接口
/// </summary>
/// <typeparam name="TCreator">创建人类型</typeparam>
public interface IMayHaveCreator<TCreator>
{
    /// <summary>
    /// 创建人
    /// </summary>
    TCreator? Creator { get; }
}
