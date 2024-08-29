using Bookshop_be.src.application.DTOs;
using MediatR;

namespace Bookshop_be.src.application.Commands
{
    public class SaveOrderCommand : IRequest<int>
    {
        public OrderDto Order { get; }

        public SaveOrderCommand(OrderDto order)
        {
            Order = order;
        }
    }
}