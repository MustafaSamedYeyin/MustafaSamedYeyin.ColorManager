using Core.Entities;
using Core.StringValues;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EfCore.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Name).HasMaxLength(50).IsRequired();
            builder.Property(i => i.Description).HasMaxLength(200);
            builder.HasMany(i => i.UserRoles).WithOne(i => i.Role).HasForeignKey(i => i.RoleId);
            builder.HasData(new Role()
            {
                Id = 1,
                Name = RoleValues.Admin,
                Description = RoleValues.Admin,
            });
            builder.HasData(new Role()
            {
                Id = 2,
                Name = RoleValues.Moderator,
                Description = RoleValues.Moderator,
            });
            builder.HasData(new Role()
            {
                Id = 3,
                Name = RoleValues.Designer,
                Description = RoleValues.Designer,
            });
            builder.HasData(new Role()
            {
                Id = 4,
                Name = RoleValues.Viewer,
                Description = RoleValues.Viewer,
            });
        }
    }
}