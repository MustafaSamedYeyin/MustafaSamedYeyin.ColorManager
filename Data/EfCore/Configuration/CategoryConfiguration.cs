using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EfCore.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(i => i.Name).HasMaxLength(400);
            builder.HasMany(i => i.PalatteCategories).WithOne(i => i.Category).HasForeignKey(i => i.CategoryId);
        }
    }
}