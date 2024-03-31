using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class Result
    {
        [JsonPropertyName("color_name")]
        public string Color { get; set; }

        [JsonPropertyName("part_img_url")]
        public string Image { get; set; }
    }
}
