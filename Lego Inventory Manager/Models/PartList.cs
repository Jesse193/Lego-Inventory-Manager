using LegoInventoryManager.Models;
using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class PartList
    {
        [JsonPropertyName("part_num")]
        public string PartNumber { get; set; }

        [JsonPropertyName("color_id")]
        public int ColorId { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("list_id")]
        public string ListId { get; set; }

        [JsonPropertyName("count")]
        public int NumberParts { get; set; }

        [JsonPropertyName("results")]
        public List<ListShow> Results { get; set; }
    }

    public class PostResponse
    {
        public int Id { get; set; }
    }

    public class ListShow
    {
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("list_id")]
        public int? ListId { get; set; }

        [JsonPropertyName("part")]
        public ListPart ListPart { get; set; }

        [JsonPropertyName("color")]
        public ListPartColor ListPartColor { get; set; }
    }

    public class ListPart
    {
        [JsonPropertyName("part_num")]
        public string PartNumber { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class ListPartColor
    {
        [JsonPropertyName("id")]
        public int ColorId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
/* GET list/parts 
 * {
  "count": 2,
  "next": null,
  "previous": null,
  "results": [
    {
      "list_id": 624813,
      "quantity": 1,
      "part": {
        "part_num": "3941",
        "name": "Brick Round 2 x 2 with Axle Hole",
        "part_cat_id": 20,
        "part_url": "https://rebrickable.com/parts/3941/brick-round-2-x-2-with-axle-hole/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/614301.jpg",
        "external_ids": {
          "BrickLink": [
            "3941"
          ],
          "BrickOwl": [
            "997602"
          ],
          "Brickset": [
            "39223",
            "6116",
            "6143"
          ],
          "LDraw": [
            "3941",
            "6143"
          ],
          "LEGO": [
            "39223",
            "6116",
            "6143"
          ]
        },
        "print_of": null
      },
      "color": {
        "id": 0,
        "name": "Black",
        "rgb": "05131D",
        "is_trans": false,
        "external_ids": {
          "BrickLink": {
            "ext_ids": [
              11
            ],
            "ext_descrs": [
              [
                "Black"
              ]
            ]
          },
          "BrickOwl": {
            "ext_ids": [
              38
            ],
            "ext_descrs": [
              [
                "Black"
              ]
            ]
          },
          "LEGO": {
            "ext_ids": [
              26,
              342
            ],
            "ext_descrs": [
              [
                "Black",
                "BLACK"
              ],
              [
                "CONDUCT. BLACK"
              ]
            ]
          },
          "Peeron": {
            "ext_ids": [
              null
            ],
            "ext_descrs": [
              [
                "black"
              ]
            ]
          },
          "LDraw": {
            "ext_ids": [
              0,
              256
            ],
            "ext_descrs": [
              [
                "Black"
              ],
              [
                "Rubber_Black"
              ]
            ]
          }
        }
      }
    },
    {
      "list_id": 624813,
      "quantity": 20,
      "part": {
        "part_num": "3941",
        "name": "Brick Round 2 x 2 with Axle Hole",
        "part_cat_id": 20,
        "part_url": "https://rebrickable.com/parts/3941/brick-round-2-x-2-with-axle-hole/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/614301.jpg",
        "external_ids": {
          "BrickLink": [
            "3941"
          ],
          "BrickOwl": [
            "997602"
          ],
          "Brickset": [
            "39223",
            "6116",
            "6143"
          ],
          "LDraw": [
            "3941",
            "6143"
          ],
          "LEGO": [
            "39223",
            "6116",
            "6143"
          ]
        },
        "print_of": null
      },
      "color": {
        "id": 1,
        "name": "Blue",
        "rgb": "0055BF",
        "is_trans": false,
        "external_ids": {
          "BrickLink": {
            "ext_ids": [
              7
            ],
            "ext_descrs": [
              [
                "Blue"
              ]
            ]
          },
          "BrickOwl": {
            "ext_ids": [
              39
            ],
            "ext_descrs": [
              [
                "Blue"
              ]
            ]
          },
          "LEGO": {
            "ext_ids": [
              23
            ],
            "ext_descrs": [
              [
                "Bright Blue",
                "BR.BLUE"
              ]
            ]
          },
          "Peeron": {
            "ext_ids": [
              null
            ],
            "ext_descrs": [
              [
                "blue"
              ]
            ]
          },
          "LDraw": {
            "ext_ids": [
              1
            ],
            "ext_descrs": [
              [
                "Blue"
              ]
            ]
          }
        }
      }
    }
  ]
} */