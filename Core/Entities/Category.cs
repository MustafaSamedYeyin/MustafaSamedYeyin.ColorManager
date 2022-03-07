using System;

namespace Core.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<PalatteCategory>? PalatteCategories { get; set; }
    }
}
