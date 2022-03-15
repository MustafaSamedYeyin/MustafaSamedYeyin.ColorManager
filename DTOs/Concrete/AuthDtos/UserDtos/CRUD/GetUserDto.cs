namespace DTOs.Concrete.AuthDtos.UserDtos.CRUD
{
    public class GetUserDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? UserName { get; set; }
    }
}