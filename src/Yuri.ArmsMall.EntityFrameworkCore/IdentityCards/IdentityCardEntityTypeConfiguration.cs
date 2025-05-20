using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Yuri.ArmsMall.IdentityCards;

/// <summary>
/// 
/// </summary>
public class IdentityCardEntityTypeConfiguration : IEntityTypeConfiguration<IdentityCard>
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<IdentityCard> builder)
    {
        builder.ToTable($"{ArmsMallConsts.DbTablePrefix}{nameof(IdentityCard)}", ArmsMallConsts.DbSchema);
        builder.ConfigureByConvention();
        builder.Property(identityCard => identityCard.Name).IsRequired().HasMaxLength(IdentityCardConsts.MaxNameLength);
        builder.Property(identityCard => identityCard.Address).IsRequired().HasMaxLength(IdentityCardConsts.MaxAddressLength);
        builder.Property(identityCard => identityCard.Number).IsRequired().HasMaxLength(IdentityCardConsts.NumberLength);
    }
}
