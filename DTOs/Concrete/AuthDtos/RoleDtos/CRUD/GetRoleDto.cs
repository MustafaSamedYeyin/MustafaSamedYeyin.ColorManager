using DTOs.Concrete.AuthDtos.UserDtos.CRUD;
using DTOs.Interfaces;

namespace DTOs.Concrete.AuthDtos.RoleDtos.CRUD
{
    public class GetRoleDto : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}