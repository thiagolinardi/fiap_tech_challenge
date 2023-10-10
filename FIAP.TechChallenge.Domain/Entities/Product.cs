using System;
using FIAP.Crosscutting.Domain.Entities;

namespace FIAP.TechChallenge.Domain.Entities
{
	public class Product : Entity
    {
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public virtual ProductCategory ProductCategory { get; set; }
    }
}

