using AutoMapper;
using Yuri.ArmsMall.Countries;
using Yuri.ArmsMall.IdentityCards;

namespace Yuri.ArmsMall;

/// <summary>
/// 
/// </summary>
public class ArmsMallApplicationAutoMapperProfile : Profile
{
    /// <summary>
    /// 
    /// </summary>
    public ArmsMallApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Country, CountryDto>();
        CreateMap<IdentityCard, IdentityCardDto>();
    }
}
