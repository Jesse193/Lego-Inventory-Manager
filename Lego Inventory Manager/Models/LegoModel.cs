using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class LegoModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("part_num")]
        public string PartNumber { get; set; }
        [JsonPropertyName("part_img_url")]
        public string Image { get; set; }
    }
}
