using AutoMapper;
using AutomapperExample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutomapperExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper _mapper;
        public CustomerController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public CustomerDto GetCustomer()
        {
            var customer = new Customer
            {
                Id = 1,
                Name = "X",
                Address = "Aydin",
                Age = 30,
                Email = "fatih@fatih.com",
                Status = 1
            };
            var customerDto = _mapper.Map<CustomerDto>(customer);
            return customerDto;
        }

        public List<CustomerDto> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer {Id=1, Name="X", Address="Aydin", Age=20, Email="x@gmail.com"},
                new Customer {Id=2, Name="Y", Address="İzmir", Age=30, Email="y@gmail.com"},
                new Customer {Id=3, Name="Z", Address="Mugla", Age=40, Email="z@gmail.com"},
            };

            var data = _mapper.Map<List<CustomerDto>>(customers);
            return data;

        }
    }
}
