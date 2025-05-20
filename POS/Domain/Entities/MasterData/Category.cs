using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.MasterData
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nama kategori wajib diisi.")]
        [StringLength(50, ErrorMessage = "Nama kategori maksimal 50 karakter.")]
        public string Name { get; set; } = string.Empty;

        [StringLength(200, ErrorMessage = "Deskripsi maksimal 200 karakter.")]
        public string Description { get; set; } = string.Empty;
    }
}
