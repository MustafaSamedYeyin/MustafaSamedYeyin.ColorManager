using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EfCore.Configuration
{
    public class PalatteCategoryConfiguration : IEntityTypeConfiguration<PalatteCategory>
    {
        public void Configure(EntityTypeBuilder<PalatteCategory> builder)
        {
            throw new NotImplementedException();
        }
    }
}