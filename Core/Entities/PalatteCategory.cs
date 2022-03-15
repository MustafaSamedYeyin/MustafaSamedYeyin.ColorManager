using System;
using Core.Entities.Interface;

namespace Core.Entities
{
    public class PalatteCategory: IEntity
    {
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
        public Palatte? Palatte { get; set; }
        public int  PalatteId { get; set; }
    }
}
