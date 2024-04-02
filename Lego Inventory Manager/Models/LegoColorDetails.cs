using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class LegoColorDetails
    {
        [JsonPropertyName("part")]
        public Part Part { get; set; }
    }

    public class Part
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("part_num")]
        public string PartNumber { get; set; }

        [JsonPropertyName("year_from")]
        public int YearFrom { get; set; }

        [JsonPropertyName("year_to")]
        public int YearTo { get; set; }

        [JsonPropertyName("part_img_url")]
        public string Image { get; set; }

        [JsonPropertyName("prints")]
        public List<string> Prints { get; set; }

    }
}
