namespace FIAP.TechChallenge.Domain.DataTransferObjects
{
    public class OrderDto
	{
        public Guid CustomerId { get; set; }
        public decimal Total { get; set; }
        public IList<OrderItem> OrderItems { get; set; }
        public DateTime CreatedAt { get; set; }

        public class OrderItem
        {
            public Guid ProductId { get; set; }
            public int Quantity { get; set; }
        }
    }
}