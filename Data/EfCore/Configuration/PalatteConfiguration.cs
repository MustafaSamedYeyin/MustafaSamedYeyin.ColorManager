using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EfCore.Configuration
{
    public class PalatteConfiguration : IEntityTypeConfiguration<Palatte>
    {
        public void Configure(EntityTypeBuilder<Palatte> builder)
        {
            throw new NotImplementedException();
        }
    }
}