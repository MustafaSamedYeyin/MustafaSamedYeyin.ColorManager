using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EfCore.Configuration
{
    public class ColorPalatteConfiguration : IEntityTypeConfiguration<ColorPalatte>
    {
        public void Configure(EntityTypeBuilder<ColorPalatte> builder)
        {
            builder.HasKey(i => new {
                i.ColorId,
                i.PalatteId
            });
            builder.HasOne(i=> i.Color).WithMany(i=> i.ColorPalatte).HasForeignKey(i=> i.ColorId);
            builder.HasOne(i=> i.Palatte).WithMany(i=> i.ColorPalattes).HasForeignKey(i=> i.PalatteId);
        }
    }
}