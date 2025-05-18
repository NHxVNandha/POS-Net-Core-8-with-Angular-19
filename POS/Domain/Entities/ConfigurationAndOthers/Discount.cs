using System;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.ConfigurationAndOthers
{
    public class Discount
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Percentage { get; set; } // Diskon dalam persentase (0 - 100)

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
