using System;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.Transactions
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "ID Transaksi wajib diisi.")]
        public Guid TransactionId { get; set; }

        [Required(ErrorMessage = "Metode pembayaran wajib diisi.")]
        [StringLength(50, ErrorMessage = "Metode pembayaran maksimal 50 karakter.")]
        public string PaymentMethod { get; set; } = string.Empty;

        [Required(ErrorMessage = "Jumlah pembayaran wajib diisi.")]
        [Range(0, double.MaxValue, ErrorMessage = "Jumlah pembayaran tidak boleh negatif.")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Tanggal pembayaran wajib diisi.")]
        public DateTime PaymentDate { get; set; }
    }
}
