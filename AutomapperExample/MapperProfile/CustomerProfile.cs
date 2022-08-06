using AutoMapper;
using AutomapperExample.Models;

namespace AutomapperExample.MapperProfile
{
    public class CustomerProfile : Profile
    {

        public CustomerProfile()
        {


            CreateMap<Customer, CustomerDto>()
                .ForMember(destination => destination.Name, operation => operation
                .MapFrom(source => source.Name + " - " + source.Email))


                .ForMember(destination => destination.CustomerStatus, operation => operation
                .MapFrom(source => ((CustomerStatusEnum)source.Status).ToString()));

            // Customer isimli entity'i customerdto'ya map etmesini soyledik. Ilki kaynak (cutomer) ikincisi cevrilecek olan (customerdto)
            //CreateMap<Customer, CustomerDto>();
            //CreateMap<CustomerDto, Customer>();
        }


    }

}
