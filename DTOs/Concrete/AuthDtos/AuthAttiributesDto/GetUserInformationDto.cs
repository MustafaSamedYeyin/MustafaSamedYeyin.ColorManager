using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Concrete.AuthDtos.AuthAttiributesDto
{
    public class GetUserInformationDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
