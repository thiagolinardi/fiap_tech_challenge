namespace FIAP.TechChallenge.Application.ViewModels
{
    public class OrderRequestViewModel
	{
        /// <summary>
        /// Código do cliente
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Valor total do pedido
        /// </summary>
        public decimal Total { get; set; }

        public IList<OrderItem> OrderItems { get; set; }

        public class OrderItem
        {
            /// <summary>
            /// Código do produto
            /// </summary>
            public Guid ProductId { get; set; }

            /// <summary>
            /// Quantidade do produto
            /// </summary>
            public int Quantity { get; set; }
        }
    }
}

