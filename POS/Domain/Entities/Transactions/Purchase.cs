using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.Transactions
{
    public class Purchase
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nomor faktur wajib diisi.")]
        [StringLength(20, ErrorMessage = "Nomor faktur maksimal 20 karakter.")]
        public string InvoiceNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tanggal pembelian wajib diisi.")]
        public DateTime PurchaseDate { get; set; }

        [Required(ErrorMessage = "ID Pemasok wajib diisi.")]
        public Guid SupplierId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Total tidak boleh negatif.")]
        public decimal TotalAmount { get; set; }

        // Navigational Property
        public ICollection<PurchaseDetail>? PurchaseDetails { get; set; }
    }
}
