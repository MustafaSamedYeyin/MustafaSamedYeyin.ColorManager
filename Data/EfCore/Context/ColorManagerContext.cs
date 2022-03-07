using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.EfCore.Context
{
    public class ColorManagerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ColorManagerContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User>?  Users{ get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<UserRole>? UserRoles { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Color>? Colors { get; set; }
        public DbSet<ColorPalatte>? ColorPalattes { get; set; }
        public DbSet<Palatte>? Palattes{ get; set; }
        public DbSet<PalatteCategory>? PalatteCategories { get; set; }
    }
}