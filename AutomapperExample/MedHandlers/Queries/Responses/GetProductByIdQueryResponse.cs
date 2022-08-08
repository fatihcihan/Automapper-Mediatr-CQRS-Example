using System;

namespace AutomapperExample.MedHandlers.Queries.QueryModels.Responses
{
    public class GetProductByIdQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
