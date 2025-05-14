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
        builder.Property(country => country.IOS2).IsRequired().HasMaxLength(CountryConsts.Ios2Length);
        builder.Property(country => country.IOS3).IsRequired().HasMaxLength(CountryConsts.Ios3Length);
        builder.Property(country => country.Number).IsRequired().HasMaxLength(CountryConsts.MaxNumberLength);
        builder.Property(country => country.Name).IsRequired().HasMaxLength(CountryConsts.MaxNameLength);
    }
}
