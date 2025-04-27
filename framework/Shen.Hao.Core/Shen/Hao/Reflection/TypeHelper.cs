namespace Shen.Hao.Reflection;

/// <summary>
/// 
/// </summary>
public static class TypeHelper
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public static object? GetDefaultValue(Type type)
    {
        if (type.IsValueType) { return Activator.CreateInstance(type); }
        return null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static bool IsDefaultValue(object? obj)
    {
        if (obj == null) { return true; }
        return obj.Equals(GetDefaultValue(obj.GetType()));
    }
}
