using System.Runtime.CompilerServices;

namespace System;

/// <summary>
/// 所有对象的扩展方法。
/// </summary>
public static class ObjectExtensions
{
    /// <summary>
    /// 用于简化和美化将对象转换为类型。
    /// </summary>
    /// <typeparam name="T">待铸造类型</typeparam>
    /// <param name="obj">要铸造的对象</param>
    /// <returns>铸造对象</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static T As<T>(this object obj) where T : class
    {
        return (T)obj;
    }
}
