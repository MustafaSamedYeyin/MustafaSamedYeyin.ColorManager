using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EfCore.Configuration
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasKey(i=> i.Id);
            builder.Property(i=> i.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(i=> i.Hex).HasMaxLength(7);
            builder.Property(i=> i.Rgb).HasMaxLength(7);
            builder.Property(i=> i.Rgba).HasMaxLength(9);
            builder.HasMany(i=> i.ColorPalatte).WithOne(i=> i.Color).HasForeignKey(i=> i.ColorId);
        }
    }
}