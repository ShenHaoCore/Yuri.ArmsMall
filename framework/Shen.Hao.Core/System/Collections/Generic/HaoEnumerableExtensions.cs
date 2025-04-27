namespace System.Collections.Generic;

/// <summary>
/// 
/// </summary>
public static class HaoEnumerableExtensions
{
    /// <summary>
    /// 使用每个成员之间的指定分隔符连接集合的成员。
    /// 快捷方式是 string.Join(...)
    /// </summary>
    /// <param name="source">要连接的对象的集合。</param>
    /// <param name="separator">用作分隔符的字符串。只有当值有多个元素时，分隔符才会包含在返回的字符串中。</param>
    /// <typeparam name="T">值成员的类型。</typeparam>
    /// <returns>由分隔符字符串分隔的值的成员组成的字符串。如果值没有成员，则该方法返回 System.String.Empty。</returns>
    public static string JoinAsString<T>(this IEnumerable<T> source, string separator)
    {
        return string.Join(separator, source);
    }
}
