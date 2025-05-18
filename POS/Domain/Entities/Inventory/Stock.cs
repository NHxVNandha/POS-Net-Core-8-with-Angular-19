using System;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.Inventory
{
    public class Stock
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Location { get; set; }

        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
}
