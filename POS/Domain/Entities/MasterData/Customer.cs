using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.MasterData
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nama pelanggan wajib diisi.")]
        [StringLength(100, ErrorMessage = "Nama pelanggan maksimal 100 karakter.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Alamat wajib diisi.")]
        [StringLength(250, ErrorMessage = "Alamat maksimal 250 karakter.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nomor telepon wajib diisi.")]
        [Phone(ErrorMessage = "Format nomor telepon tidak valid.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Format email tidak valid.")]
        public string Email { get; set; } = string.Empty;
    }
}
