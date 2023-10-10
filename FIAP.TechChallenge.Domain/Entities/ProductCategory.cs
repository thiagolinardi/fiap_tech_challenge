using System;
using FIAP.Crosscutting.Domain.Entities;

namespace FIAP.TechChallenge.Domain.Entities
{
	public class ProductCategory : Entity
    {
		public string Name { get; set; }
		public string Description { get; set; }
	}
}

