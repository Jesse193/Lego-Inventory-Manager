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

    public class SetShow
    {
        [JsonPropertyName("count")]
        public int PartCount { get; set; }

        [JsonPropertyName("results")]
        public List<SetPartList> Results { get; set; }
    }

    public class SetPartList
    {
        [JsonPropertyName("part")]
        public SetPart SetPart { get; set; }

        [JsonPropertyName("color")]
        public SetPartColor SetPartColor { get; set; }
    }

    public class SetPart
    {
        [JsonPropertyName("part_num")]
        public string PartNumber { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("part_img_url")]
        public string PartImage { get; set; }
    }

    public class SetPartColor
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("element_id")]
        public string ElementId { get; set; }

        [JsonPropertyName("is_spare")]
        public bool IsSpare { get; set; }
    }
}