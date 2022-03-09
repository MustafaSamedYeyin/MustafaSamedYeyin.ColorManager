using System;

namespace Core.Entities
{
    public class Palatte
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<PalatteCategory>? PalatteCategories { get; set; }
        public List<ColorPalatte>? ColorPalattes { get; set; }

    }
}
