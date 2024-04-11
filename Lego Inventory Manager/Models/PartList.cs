using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class PartList
    {
        [JsonPropertyName("results")]
        public List<Results>? Results { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("num_parts")]
        public int? NumParts { get; set; }
    }

    public class Results
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("num_parts")]
        public int? NumParts { get; set; }
    }
}