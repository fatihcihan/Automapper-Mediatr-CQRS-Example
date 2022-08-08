using AutoMapper;
using AutomapperExample.MedHandlers.Commands.Requests;
using AutomapperExample.MedHandlers.Commands.Responses;
using AutomapperExample.Models;
using AutomapperExample.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AutomapperExample.MedHandlers.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        public Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var mapProductRequest = _mapper.Map<Product>(request);  //gelen update request'ini entity'e mapledik
            var product = _productRepository.UpdateProduct(mapProductRequest);  // product repo tarafindan ilgili metodu cagirdik
            var mapProduct = _mapper.Map<UpdateProductCommandResponse>(product); // donus tipinde de  ilgili entityi response tipine dondurduk
            return Task.FromResult(mapProduct);
        }
    }
}
