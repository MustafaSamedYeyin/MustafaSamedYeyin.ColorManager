using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EfCore.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(i => i.Name).HasMaxLength(400);
            builder.Property(i => i.Email).HasMaxLength(400);
            builder.Property(i => i.PhoneNumber).HasMaxLength(400);
            builder.Property(i => i.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(i => i.DateOfBirth).HasDefaultValueSql("GETDATE()");
            builder.HasMany(i => i. UserRoles).WithOne(i => i.User).HasForeignKey(i => i.UserId);
        }
    }
}