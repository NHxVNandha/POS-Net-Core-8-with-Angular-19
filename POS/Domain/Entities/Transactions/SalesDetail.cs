using System;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.Transactions
{
    public class SalesDetail
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "ID Penjualan wajib diisi.")]
        public Guid SalesId { get; set; }

        [Required(ErrorMessage = "ID Produk wajib diisi.")]
        public Guid ProductId { get; set; }

        [Required(ErrorMessage = "Kuantitas produk wajib diisi.")]
        [Range(1, int.MaxValue, ErrorMessage = "Kuantitas minimal 1.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Harga produk wajib diisi.")]
        [Range(0, double.MaxValue, ErrorMessage = "Harga tidak boleh negatif.")]
        public decimal Price { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Total tidak boleh negatif.")]
        public decimal Total { get; set; }
    }
}
