using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class SetListSet
    {
        [JsonPropertyName("set_num")]
        public string SetNumber { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("include_spares")]
        public bool IncludeSpares { get; set; }
    }
}
/*
 * Post api/v3/users/userToken/setlists/1025289/sets/
{
    "set_num": "75333-1",
  "quantity": 1,
  "include_spares": false
}
*/