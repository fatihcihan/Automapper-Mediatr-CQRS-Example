using AutomapperExample.MedHandlers.Commands.Responses;
using MediatR;
using System;

namespace AutomapperExample.MedHandlers.Commands.Requests
{
    public class UpdateProductCommandRequest : IRequest<UpdateProductCommandResponse>
    {
        // burada da ilgili class'i IRequest'ten implement ediyoruz daha sonra donus tipini veriyoruz
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
