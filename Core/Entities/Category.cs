using System;
using Core.Entities.Interface;

namespace Core.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<PalatteCategory>? PalatteCategories { get; set; }
    }
}
