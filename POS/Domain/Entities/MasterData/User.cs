namespace POS.Domain.Entities.MasterData
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Guid RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
