using System;

namespace Core.Entities
{
    public class PalatteCategory
    {
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public Palatte? Palatte { get; set; }
        public int  PalatteId { get; set; }
    }
}
