using System;

namespace Core.Entities
{
    public class ColorPalatte
    {
        public Color? Color { get; set; }
        public int ColorId { get; set; }
        public Palatte? Palatte { get; set; }
        public int PalatteId { get; set; }

    }
}
