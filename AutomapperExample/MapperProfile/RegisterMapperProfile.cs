using AutoMapper;
using AutomapperExample.MedHandlers.Commands.Requests;
using AutomapperExample.MedHandlers.Commands.Responses;
using AutomapperExample.MedHandlers.Queries.QueryModels.Responses;
using AutomapperExample.Models;

namespace AutomapperExample.MapperProfile
{
    public class RegisterMapperProfile : Profile
    {

        public RegisterMapperProfile()
        {
            CreateMap<Product, GetProductByIdQueryResponse>();  // entity tipini ilgili response tiplerine
            CreateMap<Product, GetAllProductsQueryResponse>();
            CreateMap<Product, UpdateProductCommandResponse>();
            CreateMap<CreateProductCommandRequest, Product>();  // ilgili request tiplerini de ilgili entity'e map ediyoruz ki
            CreateMap<UpdateProductCommandRequest, Product>();  // repo ile iletisim kurarken tek bi obje uzerinden ilerlesin


            // CreateMap<Customer, CustomerDto>()
            //    .ForMember(destination => destination.Name, operation => operation
            //    .MapFrom(source => source.Name + " - " + source.Email))

            //    .ForMember(destination => destination.CustomerStatus, operation => operation
            //    .MapFrom(source => ((CustomerStatusEnum)source.Status).ToString()));

            // Customer isimli entity'i customerdto'ya map etmesini soyledik. ilki kaynak (cutomer) ikincisi cevrilecek olan (customerdto)
            //CreateMap<Customer, CustomerDto>();
            //CreateMap<CustomerDto, Customer>();
        }


    }

}
