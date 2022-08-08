using AutoMapper;
using AutomapperExample.MedHandlers.Queries.QueryModels.Requests;
using AutomapperExample.MedHandlers.Queries.QueryModels.Responses;
using AutomapperExample.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AutomapperExample.MedHandlers.Queries
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, List<GetAllProductsQueryResponse>>
    {
        // Mediatr paketinden gelen IRequestHandler'i implement ediyoruz daha sonra request ve responselari belirtiyoruz
        // Implement ettikten sonra handle methodunda gerekli configurasyonlari yapiyoruz

        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public GetAllProductsQueryHandler(IMapper mapper, IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public Task<List<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var productList = _productRepository.GetAllProducts();
            var mapProductList = _mapper.Map<List<GetAllProductsQueryResponse>>(productList);
            return Task.FromResult(mapProductList);
        }
    }
}
