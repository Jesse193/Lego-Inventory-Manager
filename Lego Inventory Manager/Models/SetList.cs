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

        [JsonPropertyName("results")]
        public List<Sets> Sets { get; set; }
    }

    public class Sets
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("num_sets")]
        public int NumberSets { get; set; }

        [JsonPropertyName("set_num")]
        public string SetNumber { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("num_parts")]
        public int NumberParts { get; set; }

        [JsonPropertyName("set_img_url")]
        public string SetImage { get; set; }

    }

    public class SetListShow
    {
        [JsonPropertyName("count")]
        public int NumberSets { get; set; }

        [JsonPropertyName("results")]
        public List<Sets> Sets { get; set; }
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

Get /api/v3/users/{userToken}/setlists/{listId}/sets/
{
  "count": 1,
  "next": null,
  "previous": null,
  "results": [
    {
      "list_id": 1025289,
      "quantity": 1,
      "include_spares": false,
      "set": {
        "set_num": "75333-1",
        "name": "Obi-Wan Kenobi's Jedi Starfighter",
        "year": 2022,
        "theme_id": 158,
        "num_parts": 282,
        "set_img_url": "https://cdn.rebrickable.com/media/sets/75333-1/103049.jpg",
        "set_url": "https://rebrickable.com/sets/75333-1/obi-wan-kenobis-jedi-starfighter/",
        "last_modified_dt": "2023-04-23T13:08:13.247495Z"
      }
    }
  ]
*/