using AutomapperExample.MedHandlers.Commands.Requests;
using AutomapperExample.MedHandlers.Queries.QueryModels.Requests;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AutomapperExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // Genel olaram Send methodunu kullanıyoruz
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region Queries

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // Send icinde ilgili request tipini veriyoruz bu request tipine gore mediator hangi handle'i cagiracagina karar veriyor.
            return Ok(await _mediator.Send(new GetAllProductsQueryRequest()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await _mediator.Send(new GetProductByIdQueryRequest { Id = id }));
        }

        #endregion



        #region Commands

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await _mediator.Send(new DeleteProductCommandRequest { Id = id }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, UpdateProductCommandRequest request)
        {
            request.Id = id;
            return Ok(await _mediator.Send(request));
        }
        #endregion

    }
}
