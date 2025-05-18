using System;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.Inventory
{
    public class StockAdjustment
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid StockId { get; set; }

        [Required]
        public int AdjustmentQuantity { get; set; }

        [Required]
        public string Reason { get; set; }

        [Required]
        public DateTime AdjustmentDate { get; set; } = DateTime.UtcNow;
    }
}
