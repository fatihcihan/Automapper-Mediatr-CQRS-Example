using System;

namespace AutomapperExample.Models
{
    public class Product
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
