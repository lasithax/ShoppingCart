namespace Bookshop_be.src.application.DTOs
{
    public class OrderDto
    {
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public List<OrderItemDto> Items { get; set; }
    }
}