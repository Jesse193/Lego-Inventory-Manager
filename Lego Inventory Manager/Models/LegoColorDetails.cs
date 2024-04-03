using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class LegoColorDetails
    {
        [JsonPropertyName("part")]
        public Part Part { get; set; }

        [JsonPropertyName("color")]
        public Color Color { get; set; }

        [JsonPropertyName("element_img_url")]
        public string Image { get; set; }
    }
}
