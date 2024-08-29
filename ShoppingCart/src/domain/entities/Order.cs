namespace Bookshop_be.src.domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }

        // Navigation property for related OrderItems
        public List<OrderItem> OrderItems { get; set; }
    }
}