using DTOs.Interfaces;

namespace DTOs.Concrete.AuthDtos.UserDtos
{
    public class UserGenericDto : IDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}