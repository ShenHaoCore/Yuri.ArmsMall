using FluentValidation;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public class CreateCountryDtoValidator : AbstractValidator<CreateCountryDto>
{
    /// <summary>
    /// 
    /// </summary>
    public CreateCountryDtoValidator()
    {
        RuleFor(x => x.Alpha2).NotEmpty().WithMessage("国家ISO2编码必填").Length(CountryConsts.Alpha2Length).WithMessage($"国家ISO2编码必须为{CountryConsts.Alpha2Length}字");
        RuleFor(x => x.Alpha3).NotEmpty().WithMessage("国家ISO3编码必填").Length(CountryConsts.Alpha3Length).WithMessage($"国家ISO3编码必须为{CountryConsts.Alpha3Length}字");
        RuleFor(x => x.Numeric).NotEmpty().WithMessage("国家数字编码必填").MaximumLength(CountryConsts.MaxNumericLength).WithMessage($"国家数字编码超出{CountryConsts.MaxNumericLength}字");
        RuleFor(x => x.NameCn).NotEmpty().WithMessage("国家中文名必填").MaximumLength(CountryConsts.MaxNameCnLength).WithMessage($"国家中文名超出{CountryConsts.MaxNameCnLength}字");
        RuleFor(x => x.NameEn).NotEmpty().WithMessage("国家英文名必填").MaximumLength(CountryConsts.MaxNameEnLength).WithMessage($"国家英文名超出{CountryConsts.MaxNameEnLength}字");
    }
}
