using System;
using System.Collections.Generic;

namespace AutomapperExample.Models
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public CustomerStatusEnum CustomerStatus { get; set; }
    }

    public enum CustomerStatusEnum
    {
        Active = 0,
        Pending = 1,
        Passive = 2,
    }
}
