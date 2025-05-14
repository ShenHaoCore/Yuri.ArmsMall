using Volo.Abp;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public class CountryAlreadyExistsException : BusinessException
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="ios2"></param>
    public CountryAlreadyExistsException(string ios2) : base(ArmsMallDomainErrorCodes.CountryAlreadyExists)
    {
        WithData(nameof(ios2), ios2);
    }
}
