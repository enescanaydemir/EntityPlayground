using System;
using EntityPlayground.src.TutorialProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityPlayground.src.TutorialProject.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Companies> Companies { get; set; }
        public DbSet<ApplicationUsers> ApplicationUsers { get; set; }
        public DbSet<ApplicationRoles> ApplicationRoles { get; set; }
        public DbSet<KPIs> KPIs { get; set; }
        public DbSet<KPIsCategory> KPIsCategory { get; set; }
        public DbSet<CompanyKPIs> CompanyKPIs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API tanımlamaları

            // CompanyKPIs -> Companies ilişkisi (Many-to-One)
            modelBuilder.Entity<CompanyKPIs>()
                .HasOne(ck => ck.Companies)
                .WithMany(c => c.CompanyKPIs)
                .HasForeignKey(ck => ck.CompanyId);

            // CompanyKPIs -> KPIs ilişkisi (Many-to-One)
            modelBuilder.Entity<CompanyKPIs>()
                .HasOne(ck => ck.KPIs)
                .WithMany(k => k.CompanyKPIs)
                .HasForeignKey(ck => ck.KPIId);

            // ApplicationUsers -> ApplicationRoles ilişkisi (One-to-Many)
            modelBuilder.Entity<ApplicationUsers>()
                .HasOne(au => au.Role)
                .WithMany(ar => ar.ApplicationUsers)
                .HasForeignKey(au => au.RoleId);

            // KPIs -> KPIsCategory ilişkisi (Many-to-One)
            modelBuilder.Entity<KPIs>()
                .HasOne(k => k.Category)
                .WithMany(c => c.KPIs)
                .HasForeignKey(k => k.CategoryId);
        }

    }
}
