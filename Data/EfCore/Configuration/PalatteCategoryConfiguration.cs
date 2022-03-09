using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EfCore.Configuration
{
    public class PalatteCategoryConfiguration : IEntityTypeConfiguration<PalatteCategory>
    {
        public void Configure(EntityTypeBuilder<PalatteCategory> builder)
        {
            builder.HasKey(i => new {
                i.PalatteId,
                i.CategoryId
            });
            builder.HasOne(i => i.Palatte).WithMany(i => i.PalatteCategories).HasForeignKey(i => i.PalatteId);
            builder.HasOne(i => i.Category).WithMany(i => i.PalatteCategories).HasForeignKey(i => i.CategoryId);
        }
    }
}