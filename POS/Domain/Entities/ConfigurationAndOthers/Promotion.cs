using System;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.ConfigurationAndOthers
{
    public class Promotion
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }
    }
}
