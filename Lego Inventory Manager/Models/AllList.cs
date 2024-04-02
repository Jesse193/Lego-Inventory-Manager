using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class AllList
    {
        [JsonPropertyName("results")]
        public List<List> data { get; set; }
    }

    public class List
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("num_parts")]
        public int NumParts { get; set; }
    }
}
