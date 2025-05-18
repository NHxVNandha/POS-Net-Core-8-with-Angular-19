using System;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.ReportsAndLogs
{
    public class AuditLog
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Action { get; set; } // Create, Update, Delete, Login, etc.

        [Required]
        public string Entity { get; set; } // Nama Entity (Product, Sale, Purchase, dll.)

        [Required]
        public string Username { get; set; } // User yang melakukan aksi

        public string Details { get; set; } // Detail informasi, bisa JSON atau plain text

        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
