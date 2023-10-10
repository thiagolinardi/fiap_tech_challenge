using System;
using FIAP.Crosscutting.Domain.Entities;

namespace FIAP.TechChallenge.Domain.Entities
{
	public class Customer : Entity
    {
		public string CPF { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
	}
}

