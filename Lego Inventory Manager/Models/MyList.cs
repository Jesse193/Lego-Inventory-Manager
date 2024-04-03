using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class MyList
    {
        [JsonPropertyName("results")]
        public List<Results> data { get; set; }

        [JsonPropertyName("count")]
        public int NumberParts { get; set; }
    }

    public class Results
    {
        [JsonPropertyName("list_id")]
        public int ListId { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("part")]
        public Part Part { get; set; }

        [JsonPropertyName("color")]
        public Color Color { get; set; }
    }
}
