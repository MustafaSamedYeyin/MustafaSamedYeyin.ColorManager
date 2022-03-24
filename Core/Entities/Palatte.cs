using System;
using Core.Entities.Interface;

namespace Core.Entities
{
    public class Palatte: IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<PalatteCategory>? PalatteCategories { get; set; }
        public int PalatteCategoryId { get; set; }
        public List<ColorPalatte>? ColorPalattes { get; set; }
        public int ColorPalatteId { get; set; }

    }
}
