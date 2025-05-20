using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Yuri.ArmsMall.Countries;

/// <summary>
/// 
/// </summary>
public class CountryEntityTypeConfiguration : IEntityTypeConfiguration<Country>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable($"{ArmsMallConsts.DbTablePrefix}{nameof(Country)}", ArmsMallConsts.DbSchema);
        builder.ConfigureByConvention();
        builder.Property(country => country.Alpha2).IsRequired().HasMaxLength(CountryConsts.Alpha2Length);
        builder.Property(country => country.Alpha3).IsRequired().HasMaxLength(CountryConsts.Alpha3Length);
        builder.Property(country => country.Numeric).IsRequired().HasMaxLength(CountryConsts.MaxNumericLength);
        builder.Property(country => country.NameCn).IsRequired().HasMaxLength(CountryConsts.MaxNameCnLength);
        builder.Property(country => country.NameEn).IsRequired().HasMaxLength(CountryConsts.MaxNameEnLength);
    }
}
