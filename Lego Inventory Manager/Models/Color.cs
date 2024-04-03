using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class Color
    {
        [JsonPropertyName("id")]
        public int ColorId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
