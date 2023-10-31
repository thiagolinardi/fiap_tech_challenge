using FIAP.Crosscutting.Domain.Entities;

namespace FIAP.TechChallenge.Domain.Entities
{
    public class OrderItem : Entity
	{
		public Guid OrderId { get; set; }
		public Guid ProductId { get; set; }
		public int Quantity { get; set; }

		public virtual Order Order { get; set; }
		public virtual Product Product { get; set; }
	}
}
