using DTOs.Interfaces;

namespace DTOs.Concrete.ServiceDtos.ColorDtos
{
    public class ColorGenericDto : IDto
    {
        public string? Id{ get; set; }
        public string Hex { get; set; }
    }
}