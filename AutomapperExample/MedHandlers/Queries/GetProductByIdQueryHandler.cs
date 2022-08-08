using AutoMapper;
using AutomapperExample.MedHandlers.Queries.QueryModels.Requests;
using AutomapperExample.MedHandlers.Queries.QueryModels.Responses;
using AutomapperExample.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AutomapperExample.MedHandlers.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQueryRequest, GetProductByIdQueryResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public Task<GetProductByIdQueryResponse> Handle(GetProductByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var product = _productRepository.GetProductById(request.Id); // repodaki ilgili operasyonu cagiriyoruz (product donuyor)
            var mapProduct = _mapper.Map<GetProductByIdQueryResponse>(product); // donen entity tipini response tipine mapliyoruz
            return Task.FromResult(mapProduct);                             // ilgili response'u controller'a donuyoruz
        }
    }
}
