using Volo.Abp;

namespace Yuri.ArmsMall.IdentityCards;

/// <summary>
/// 
/// </summary>
public class ExistsNumberException : BusinessException
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="number">身份证</param>
    public ExistsNumberException(string number) : base(ArmsMallDomainErrorCodes.CountryAlreadyExists)
    {
        WithData(nameof(number), number);
    }
}
