using AutomapperExample.MedHandlers.Queries.QueryModels.Responses;
using MediatR;
using System.Collections.Generic;

namespace AutomapperExample.MedHandlers.Queries.QueryModels.Requests
{
    public class GetAllProductsQueryRequest : IRequest<List<GetAllProductsQueryResponse>>   //IRequest<DonusTipi>
    {
        // MediatR altindan gelen irequest'ten implement edilmesi lazim ve daha sonra donus tipini (response) yaziyoruz
    }
}
