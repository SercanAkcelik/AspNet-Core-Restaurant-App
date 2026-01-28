/*
 * -----------------------------------------------------------------------------
 * PROJE: LezzetBurger - Restoran Yönetim Sistemi
 * DOSYA: Models/Product.cs
 * 
 * AÇIKLAMA:
 * Bu sınıf, 'Ürün' varlığını (Entity) temsil eden veri modelidir.
 * Veritabanındaki 'Products' tablosuna karşılık gelir.
 * Data Annotations ([Required], [StringLength]) kullanılarak veri doğrulama
 * kuralları tanımlanmıştır. Ayrıca Kategori ile ilişkisi (Relation) belirtilmiştir.
 * -----------------------------------------------------------------------------
 */

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HamburgerSite.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public string? Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }

        public bool IsActive { get; set; } = true;

        // Foreign Key
        public int CategoryId { get; set; }

        // Navigation Property
        public Category? Category { get; set; }
    }
}
