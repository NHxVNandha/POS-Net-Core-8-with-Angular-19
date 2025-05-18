using System;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.Inventory
{
    public class StockTransfer
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid StockId { get; set; }

        [Required]
        public string FromLocation { get; set; }

        [Required]
        public string ToLocation { get; set; }

        [Required]
        public int TransferQuantity { get; set; }

        [Required]
        public DateTime TransferDate { get; set; } = DateTime.UtcNow;
    }
}
