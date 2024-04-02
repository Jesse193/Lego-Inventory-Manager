using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class PartList
    {
        [JsonPropertyName("part_num")]
        public string PartNumber {  get; set; }

        [JsonPropertyName("color_id")]
        public int ColorId { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity {  get; set; }
    }
}
