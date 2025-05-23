﻿using System;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.Transactions
{
    public class Invoice
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nomor faktur wajib diisi.")]
        [StringLength(20, ErrorMessage = "Nomor faktur maksimal 20 karakter.")]
        public string InvoiceNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tanggal faktur wajib diisi.")]
        public DateTime InvoiceDate { get; set; }

        [Required(ErrorMessage = "ID Transaksi wajib diisi.")]
        public Guid TransactionId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Total tidak boleh negatif.")]
        public decimal TotalAmount { get; set; }
    }
}
