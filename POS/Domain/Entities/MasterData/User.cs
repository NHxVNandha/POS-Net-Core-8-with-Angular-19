using System.ComponentModel.DataAnnotations;

namespace POS.Domain.Entities.MasterData
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nama pengguna wajib diisi.")]
        [StringLength(100, ErrorMessage = "Nama pengguna maksimal 100 karakter.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Username wajib diisi.")]
        [StringLength(50, ErrorMessage = "Username maksimal 50 karakter.")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password wajib diisi.")]
        [StringLength(100, ErrorMessage = "Password maksimal 100 karakter.")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Role wajib diisi.")]
        public Guid RoleId { get; set; }

        public Role? Role { get; set; }
    }
}
