using FIAP.Crosscutting.Domain.Helpers.Extensions;
using System.Text.Json.Serialization;

namespace FIAP.Crosscutting.Domain.Entities
{
    public class Entity : IEntity
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now.ToBrazilianTimezone();

        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
