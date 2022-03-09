using System;

namespace Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Passsword { get; set; }
        public string? Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? UserName { get; set; }
        public string? PhoneNumber { get; set; }
        public byte[]? Image { get; set; }
        public DateTime? CreatedAt { get; set; }
        public List<UserRole>? UserRoles { get; set; }

    }
}
