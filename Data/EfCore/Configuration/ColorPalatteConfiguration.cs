using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EfCore.Configuration
{
    public class ColorPalatteConfiguration : IEntityTypeConfiguration<ColorPalatte>
    {
        public void Configure(EntityTypeBuilder<ColorPalatte> builder)
        {
            throw new NotImplementedException();
        }
    }
}