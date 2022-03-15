using System;
using Core.Entities.Interface;

namespace Core.Entities
{
    public class Color: IEntity
    {
        public int Id { get; set; }
        public string? Hex { get; set; }
        public string? Rgb { get; set; }
        public string? Rgba { get; set; }
        public List<ColorPalatte>? ColorPalatte { get; set; }
    }
}
