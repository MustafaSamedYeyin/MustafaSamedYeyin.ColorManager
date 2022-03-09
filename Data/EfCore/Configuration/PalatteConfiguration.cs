using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EfCore.Configuration
{
    public class PalatteConfiguration : IEntityTypeConfiguration<Palatte>
    {
        public void Configure(EntityTypeBuilder<Palatte> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(i => i.Name).HasMaxLength(400);
            builder.HasMany(i => i.PalatteCategories).WithOne(i => i.Palatte).HasForeignKey(i => i.PalatteId);
            builder.HasMany(i => i.ColorPalattes).WithOne(i => i.Palatte).HasForeignKey(i => i.PalatteId);
        }
    }
}