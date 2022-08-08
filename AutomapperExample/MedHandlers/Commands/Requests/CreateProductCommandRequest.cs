using MediatR;
using System;

namespace AutomapperExample.MedHandlers.Commands.Requests
{
    public class CreateProductCommandRequest : IRequest<Guid>       // geriye id donuyoruz
    {
        public string Name { get; set; }
    }
}
