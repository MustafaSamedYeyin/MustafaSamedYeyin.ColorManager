using System;
using Core.Entities.Interface;

namespace Core.Entities
{
    public class ColorPalatte: IEntity
    {
        public Color? Color { get; set; }
        public int ColorId { get; set; }
        public Palatte? Palatte { get; set; }
        public int PalatteId { get; set; }

    }
}
