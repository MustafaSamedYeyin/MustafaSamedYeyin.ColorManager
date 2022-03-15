using System;
using Core.Entities.Interface;

namespace Core.Entities
{
    public class UserRole: IEntity
    {
        public User? User { get; set; }
        public int UserId { get; set; }
        public Role? Role { get; set; }
        public int RoleId { get; set; }
    }
}
