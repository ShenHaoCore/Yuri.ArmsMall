using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Yuri.ArmsMall;

/// <summary>
/// 
/// </summary>
[DebuggerStepThrough]
public static class Check
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="value"></param>
    /// <param name="parameterName"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static T NotNull<T>([System.Diagnostics.CodeAnalysis.NotNull] T? value, [NotNull] string parameterName)
    {
        if (value == null) { throw new ArgumentNullException(parameterName); }
        return value;
    }
}
