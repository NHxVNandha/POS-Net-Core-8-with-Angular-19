using System;
using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.ConfigurationAndOthers
{
    public class Setting
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string StoreName { get; set; }

        [Required]
        public string StoreAddress { get; set; }

        public string StoreLogo { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
