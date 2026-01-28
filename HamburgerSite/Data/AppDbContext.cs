/*
 * -----------------------------------------------------------------------------
 * PROJE: LezzetBurger - Restoran Yönetim Sistemi
 * DOSYA: Data/AppDbContext.cs
 * 
 * AÇIKLAMA:
 * Bu sınıf, uygulamanın Veritabanı Bağlamını (Database Context) temsil eder.
 * Entity Framework Core kullanılarak Code-First yaklaşımıyla tasarlanmıştır.
 * Veritabanı tabloları (DbSet) ve ilişkileri burada tanımlanır.
 * -----------------------------------------------------------------------------
 */

using Microsoft.EntityFrameworkCore;
using HamburgerSite.Models;

namespace HamburgerSite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Optional: configurations if needed
        }
    }
}
