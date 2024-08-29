using Bookshop_be.src.domain.Entities;
using Bookshop_be.src.infrastructure.Data;
using MediatR;

namespace Bookshop_be.src.application.Commands
{
    public class SaveOrderCommandHandler : IRequestHandler<SaveOrderCommand, int>
    {
        private readonly DataContext _context;

        public SaveOrderCommandHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(SaveOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order
            {
                OrderDate = DateTime.UtcNow,
                Status = request.Order.Status,
                OrderItems = request.Order.Items.Select(i => new OrderItem
                {
                    ProductId = i.ProductId,
                    Quantity = i.Quantity,
                    Price = i.Price
                }).ToList()
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync(cancellationToken);

            return order.OrderId;
        }
    }
}