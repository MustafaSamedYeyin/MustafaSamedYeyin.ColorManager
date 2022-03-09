using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EfCore.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(i => new {
                i.UserId,
                i.RoleId
            });
            builder.HasOne(i => i.User).WithMany(i => i.UserRoles).HasForeignKey(i => i.UserId);
            builder.HasOne(i => i.Role).WithMany(i => i.UserRoles).HasForeignKey(i => i.RoleId);
        }
    }
}