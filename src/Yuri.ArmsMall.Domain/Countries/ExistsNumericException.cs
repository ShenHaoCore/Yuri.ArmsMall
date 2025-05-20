using Volo.Abp;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public class ExistsNumericException : BusinessException
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="numeric">ISO3编码</param>
    public ExistsNumericException(string numeric) : base(ArmsMallDomainErrorCodes.CountryAlreadyExists)
    {
        WithData(nameof(numeric), numeric);
    }
}
