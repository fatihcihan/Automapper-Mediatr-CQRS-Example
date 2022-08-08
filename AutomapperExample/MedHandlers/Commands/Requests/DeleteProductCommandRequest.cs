using MediatR;
using System;

namespace AutomapperExample.MedHandlers.Commands.Requests
{
    public class DeleteProductCommandRequest : IRequest<bool>   // geriye bool donuyoruz
    {
        public Guid Id { get; set; }
    }
}
