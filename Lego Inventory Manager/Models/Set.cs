using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class Set
    {
        [JsonPropertyName("results")]
        public List<SetResults> Results { get; set; }
    }

    public class SetResults
    {
        [JsonPropertyName("set_num")]
        public string SetNumber { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("num_parts")]
        public int NumParts { get; set; }

        [JsonPropertyName("set_img_url")]
        public string Image { get; set; }
    }
}