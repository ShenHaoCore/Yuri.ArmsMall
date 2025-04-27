using JetBrains.Annotations;
using System.Diagnostics;

namespace Shen.Hao;

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
    [ContractAnnotation("value:null => halt")]
    public static T NotNull<T>([System.Diagnostics.CodeAnalysis.NotNull] T? value, [InvokerParameterName][NotNull] string parameterName)
    {
        if (value == null) { throw new ArgumentNullException(parameterName); }
        return value;
    }
}
