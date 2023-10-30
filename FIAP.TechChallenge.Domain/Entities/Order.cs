using FIAP.Crosscutting.Domain.Entities;

namespace FIAP.TechChallenge.Domain.Entities
{
    public class Order : Entity
    {
		public Guid? CustomerId { get; set; }
		public decimal Total { get; set; }

		public virtual Customer Customer { get; set; }
		public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}

