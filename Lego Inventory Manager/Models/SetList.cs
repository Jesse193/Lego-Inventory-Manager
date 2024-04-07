using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class SetList
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("num_sets")]
        public int NumberSets { get; set; }
    }
{