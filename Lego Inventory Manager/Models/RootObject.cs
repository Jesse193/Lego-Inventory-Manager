using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class RootObject
    {
        [JsonPropertyName("results")]
        public List<Result> result { get; set; }
        public string PartNumber {get; set;}
    }
}
