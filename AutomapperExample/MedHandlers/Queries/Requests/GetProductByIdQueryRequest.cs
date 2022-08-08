using AutomapperExample.MedHandlers.Queries.QueryModels.Responses;
using MediatR;
using System;

namespace AutomapperExample.MedHandlers.Queries.QueryModels.Requests
{
    public class GetProductByIdQueryRequest : IRequest<GetProductByIdQueryResponse>     //irequest<DonusTipi>
    {
        // MediatR altindan gelen irequest'ten implement edilmesi lazim 
        // Parametre olarak id aldigini belirtiyoruz ve response olarak geriye tek bi tane product donuyoruz
        public Guid Id { get; set; }        // parametre olarak id aliyor
    }
}
