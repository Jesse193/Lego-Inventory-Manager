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

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("results")]
        public List<SetListResults> Results { get; set; }
    }
    public class SetListResults
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("num_sets")]
        public int NumberSets { get; set; }
    }
}

/*
 * Get /api/v3/users/{userToken}/setlists
 * {
  "count": 2,
  "next": null,
  "previous": null,
  "results": [
    {
      "id": 1025292,
      "is_buildable": false,
      "name": "new test",
      "num_sets": 0
    },
    {
      "id": 1025289,
      "is_buildable": false,
      "name": "test",
      "num_sets": 1
    }
  ]
}
*/