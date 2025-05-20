using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.MasterData
{
    public class Tax
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nama pajak wajib diisi.")]
        [StringLength(50, ErrorMessage = "Nama pajak maksimal 50 karakter.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Persentase pajak wajib diisi.")]
        [Range(0, 100, ErrorMessage = "Persentase pajak harus antara 0 hingga 100.")]
        public decimal Percentage { get; set; }
    }
}
