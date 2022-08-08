using AutoMapper;
using AutomapperExample.MedHandlers.Commands.Requests;
using AutomapperExample.Models;
using AutomapperExample.Repositories;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AutomapperExample.MedHandlers.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, Guid>
    {
        // Ilgili class IRequestHandler'dan implement edilecek, verdigimiz request tipinin de irequest'ten implement edilmis olmasi lazim 
        
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Task<Guid> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var mapProduct = _mapper.Map<Product>(request); // burada da request'i aldik ve entity'e mapledik (repo'ya gonderecegimiz icin)
            var productId = _productRepository.AddProduct(mapProduct);  // repo'dan ilgili metottan id'yi aldik controller'a donduk
            return Task.FromResult(productId);
        }
    }
}
