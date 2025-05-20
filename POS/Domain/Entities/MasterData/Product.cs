using System;
using System.ComponentModel.DataAnnotations;
using POS.Domain.Entities.MasterData;

namespace POS.Domain.Entities.MasterData
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Kode produk wajib diisi.")]
        [StringLength(20, ErrorMessage = "Kode produk maksimal 20 karakter.")]
        public string Code { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nama produk wajib diisi.")]
        [StringLength(100, ErrorMessage = "Nama produk maksimal 100 karakter.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Harga produk wajib diisi.")]
        [Range(0, double.MaxValue, ErrorMessage = "Harga tidak boleh negatif.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stok produk wajib diisi.")]
        [Range(0, int.MaxValue, ErrorMessage = "Stok tidak boleh negatif.")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Kategori wajib diisi.")]
        public Guid CategoryId { get; set; }

        // Relasi ke Category
        public Category? Category { get; set; }
    }
}
