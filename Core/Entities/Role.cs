using System;
using Core.Entities.Interface;

namespace Core.Entities
{
    public class Role: IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<UserRole>? UserRoles { get; set; }

    }
}
