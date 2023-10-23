using FIAP.Crosscutting.Infrastructure.Repositories;
using FIAP.TechChallenge.Domain.Interfaces.Repositories;
using FIAP.TechChallenge.Infrastructure.Contexts;

namespace FIAP.TechChallenge.Infrastructure.Repositories
{
    public class OrderRepository : SqlRepository<Domain.Entities.Order>, IOrderRepository
    {
        public OrderRepository(SqlContext context) : base(context) { }
    }
}

