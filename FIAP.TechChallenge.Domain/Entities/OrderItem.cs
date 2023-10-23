using System;
using FIAP.Crosscutting.Domain.Entities;

namespace FIAP.TechChallenge.Domain.Entities
{
	public class OrderItem : Entity
	{
		public Guid OrderId { get; set; }
		public Guid ProductId { get; set; }
		public int Quantity { get; set; }

		public Order Order { get; set; }
		public Product Product { get; set; }
	}
}
