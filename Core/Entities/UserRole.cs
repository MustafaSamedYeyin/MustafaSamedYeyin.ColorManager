using System;

namespace Core.Entities
{
    public class UserRole
    {
        public User? User { get; set; }
        public Role? Role { get; set; }
    }
}
