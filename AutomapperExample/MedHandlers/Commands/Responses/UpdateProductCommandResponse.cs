using System;

namespace AutomapperExample.MedHandlers.Commands.Responses
{
    public class UpdateProductCommandResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
