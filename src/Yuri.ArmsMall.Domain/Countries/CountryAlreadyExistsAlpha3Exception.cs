using Volo.Abp;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public class CountryAlreadyExistsAlpha3Exception : BusinessException
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="alpha3">ISO3编码</param>
    public CountryAlreadyExistsAlpha3Exception(string alpha3) : base(ArmsMallDomainErrorCodes.CountryAlreadyExists)
    {
        WithData(nameof(alpha3), alpha3);
    }
}
