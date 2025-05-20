using Volo.Abp;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public class CountryAlreadyExistsAlpha2Exception : BusinessException
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="alpha2"></param>
    public CountryAlreadyExistsAlpha2Exception(string alpha2) : base(ArmsMallDomainErrorCodes.CountryAlreadyExists)
    {
        WithData(nameof(alpha2), alpha2);
    }
}
