using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class AllPart
    {
        [JsonPropertyName("count")]
        int Count { get; set; }

        [JsonPropertyName("next")]
        public string Next { get; set; }

        [JsonPropertyName("previous")]
        public string Previous { get; set; }

        [JsonPropertyName("results")]
        public List<AllPartDetail> Results { get; set; }
    }

    public class AllPartDetail
    {
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("part")]
        public PartResults Part { get; set; }

        [JsonPropertyName("color")]
        public Color Color { get; set; }
    }
}
