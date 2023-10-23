using FIAP.Crosscutting.Domain.Commands;

namespace FIAP.TechChallenge.Domain.Commands
{
    public abstract class OrderCommand : Command
	{
        public Guid CustomerId { get; set; }
        public decimal Total { get; set; }
        public IList<OrderItem> OrderItems { get; set; }

        public class OrderItem
        {
            public Guid ProductId { get; set; }
            public int Quantity { get; set; }
        }
    }
}

