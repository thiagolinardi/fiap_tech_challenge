using System.Text.Json.Serialization;

namespace FIAP.TechChallenge.Application.ViewModels
{
    public class OrderResponseViewModel
	{
        /// <summary>
        /// Código do pedido
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Valor total do pedido
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Items do pedido
        /// </summary>

        
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        public Items Items { get; set; }
    }

    public class Items
    {
        /// <summary>
        /// Código do produto
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// Nome do produto
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Preço do produto
        /// </summary>
        public decimal Price { get; set; }
    }
}

