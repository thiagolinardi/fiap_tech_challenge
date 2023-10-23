using FIAP.Crosscutting.Domain.Entities;

namespace FIAP.TechChallenge.Domain.Entities
{
    public class Order : Entity
    {
		public Guid CustomerId { get; set; }
		public decimal Total { get; set; }
		public Customer Customer { get; set; }
		public ICollection<OrderItem> OrderItems { get; set; }
    }
}

