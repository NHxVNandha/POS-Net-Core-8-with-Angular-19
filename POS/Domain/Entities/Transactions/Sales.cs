using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.Transactions
{
    public class Sales
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nomor faktur wajib diisi.")]
        [StringLength(20, ErrorMessage = "Nomor faktur maksimal 20 karakter.")]
        public string InvoiceNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tanggal penjualan wajib diisi.")]
        public DateTime SaleDate { get; set; }

        [Required(ErrorMessage = "ID Pelanggan wajib diisi.")]
        public Guid CustomerId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Total tidak boleh negatif.")]
        public decimal TotalAmount { get; set; }

        // Navigational Property
        public ICollection<SalesDetail>? SalesDetails { get; set; }
    }
}
