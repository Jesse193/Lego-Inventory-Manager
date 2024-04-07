using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class PartColor
    {
        [JsonPropertyName("results")]
        public List<ColorResults>? Results { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("part_num")]
        public string? PartNumber { get; set; }

        [JsonPropertyName("color")]
        public Color? Color { get; set; }

        [JsonPropertyName("element_img_url")]
        public string? Image { get; set; }
    }

    public class ColorResults
    {
        [JsonPropertyName("color_name")]
        public string? ColorName { get; set; }

        [JsonPropertyName("part_img_url")]
        public string? Image { get; set; }

        [JsonPropertyName("color_id")]
        public int? ColorId { get; set; }

        [JsonPropertyName("elements")]
        public List<string>? ElementList { get; set; }
    }
    
    public class PartColorShow
    {
        [JsonPropertyName("part")]
        public PartColor PartColor {  get; set; }

        [JsonPropertyName("color")]
        public Color Color { get; set; }
    }
    public class Color
    {
        [JsonPropertyName("id")]
        public int? ColorId { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("part_img_url")]
        public string? Image { get; set;}
    } 
}
/* GET https://rebrickable.com/api/v3/lego/parts/3941/colors/
 * {
  "count": 46,
  "next": null,
  "previous": null,
  "results": [
    {
      "color_id": 0,
      "color_name": "Black",
      "num_sets": 433,
      "num_set_parts": 1510,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/614326.jpg",
      "elements": [
        "394126",
        "614326"
      ]
    },
    {
      "color_id": 1,
      "color_name": "Blue",
      "num_sets": 118,
      "num_set_parts": 368,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/614323.jpg",
      "elements": [
        "614323"
      ]
    },
    {
      "color_id": 2,
      "color_name": "Green",
      "num_sets": 74,
      "num_set_parts": 226,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4251378.jpg",
      "elements": [
        "4251378",
        "614328"
      ]
    },
    {
      "color_id": 3,
      "color_name": "Dark Turquoise",
      "num_sets": 23,
      "num_set_parts": 53,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6290502.jpg",
      "elements": [
        "6290502"
      ]
    },
    {
      "color_id": 4,
      "color_name": "Red",
      "num_sets": 301,
      "num_set_parts": 912,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/614321.jpg",
      "elements": [
        "614321"
      ]
    },
    {
      "color_id": 5,
      "color_name": "Dark Pink",
      "num_sets": 4,
      "num_set_parts": 4,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6422439.jpg",
      "elements": [
        "4216475",
        "6422439"
      ]
    },
    {
      "color_id": 6,
      "color_name": "Brown",
      "num_sets": 23,
      "num_set_parts": 195,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/614325.jpg",
      "elements": [
        "614325"
      ]
    },
    {
      "color_id": 7,
      "color_name": "Light Gray",
      "num_sets": 100,
      "num_set_parts": 383,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/614302.jpg",
      "elements": [
        "614302"
      ]
    },
    {
      "color_id": 8,
      "color_name": "Dark Gray",
      "num_sets": 1,
      "num_set_parts": 1,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/ldraw/8/3941.png",
      "elements": [
        "4113162",
        "4239199",
        "614327"
      ]
    },
    {
      "color_id": 10,
      "color_name": "Bright Green",
      "num_sets": 6,
      "num_set_parts": 11,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4183118.jpg",
      "elements": [
        "4183118",
        "6316319"
      ]
    },
    {
      "color_id": 14,
      "color_name": "Yellow",
      "num_sets": 247,
      "num_set_parts": 829,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/614324.jpg",
      "elements": [
        "614324"
      ]
    },
    {
      "color_id": 15,
      "color_name": "White",
      "num_sets": 474,
      "num_set_parts": 2296,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/614301.jpg",
      "elements": [
        "614301"
      ]
    },
    {
      "color_id": 19,
      "color_name": "Tan",
      "num_sets": 131,
      "num_set_parts": 638,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4125220.jpg",
      "elements": [
        "4125220"
      ]
    },
    {
      "color_id": 25,
      "color_name": "Orange",
      "num_sets": 84,
      "num_set_parts": 244,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4141089.jpg",
      "elements": [
        "4141089"
      ]
    },
    {
      "color_id": 26,
      "color_name": "Magenta",
      "num_sets": 1,
      "num_set_parts": 1,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4243924.jpg",
      "elements": [
        "4243924"
      ]
    },
    {
      "color_id": 27,
      "color_name": "Lime",
      "num_sets": 91,
      "num_set_parts": 232,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4279733.jpg",
      "elements": [
        "4279733",
        "4527943"
      ]
    },
    {
      "color_id": 28,
      "color_name": "Dark Tan",
      "num_sets": 6,
      "num_set_parts": 15,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6150222.jpg",
      "elements": [
        "6150222",
        "6357806"
      ]
    },
    {
      "color_id": 31,
      "color_name": "Lavender",
      "num_sets": 14,
      "num_set_parts": 34,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6223600.jpg",
      "elements": [
        "6223600"
      ]
    },
    {
      "color_id": 33,
      "color_name": "Trans-Dark Blue",
      "num_sets": 9,
      "num_set_parts": 20,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/611643.jpg",
      "elements": [
        "4101741",
        "611643"
      ]
    },
    {
      "color_id": 35,
      "color_name": "Trans-Bright Green",
      "num_sets": 17,
      "num_set_parts": 49,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6296849.jpg",
      "elements": [
        "6296849"
      ]
    },
    {
      "color_id": 36,
      "color_name": "Trans-Red",
      "num_sets": 6,
      "num_set_parts": 13,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4260812.jpg",
      "elements": [
        "4260812",
        "6334501"
      ]
    },
    {
      "color_id": 41,
      "color_name": "Trans-Light Blue",
      "num_sets": 164,
      "num_set_parts": 408,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4178398.jpg",
      "elements": [
        "4178398",
        "6273153"
      ]
    },
    {
      "color_id": 42,
      "color_name": "Trans-Neon Green",
      "num_sets": 73,
      "num_set_parts": 222,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/611649.jpg",
      "elements": [
        "611649",
        "6273157"
      ]
    },
    {
      "color_id": 45,
      "color_name": "Trans-Dark Pink",
      "num_sets": 18,
      "num_set_parts": 47,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6296852.jpg",
      "elements": [
        "6296852"
      ]
    },
    {
      "color_id": 46,
      "color_name": "Trans-Yellow",
      "num_sets": 121,
      "num_set_parts": 321,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/611644.jpg",
      "elements": [
        "611644",
        "6273155"
      ]
    },
    {
      "color_id": 47,
      "color_name": "Trans-Clear",
      "num_sets": 106,
      "num_set_parts": 233,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4143346.jpg",
      "elements": [
        "4143346",
        "6273152"
      ]
    },
    {
      "color_id": 52,
      "color_name": "Trans-Purple",
      "num_sets": 1,
      "num_set_parts": 10,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6372260.jpg",
      "elements": [
        "6372260"
      ]
    },
    {
      "color_id": 57,
      "color_name": "Trans-Neon Orange",
      "num_sets": 55,
      "num_set_parts": 149,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/611647.jpg",
      "elements": [
        "611647",
        "6273156"
      ]
    },
    {
      "color_id": 70,
      "color_name": "Reddish Brown",
      "num_sets": 351,
      "num_set_parts": 1526,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4211166.jpg",
      "elements": [
        "4211166"
      ]
    },
    {
      "color_id": 71,
      "color_name": "Light Bluish Gray",
      "num_sets": 269,
      "num_set_parts": 1127,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4211526.jpg",
      "elements": [
        "4211526"
      ]
    },
    {
      "color_id": 72,
      "color_name": "Dark Bluish Gray",
      "num_sets": 199,
      "num_set_parts": 867,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4249139.jpg",
      "elements": [
        "4249139"
      ]
    },
    {
      "color_id": 78,
      "color_name": "Light Nougat",
      "num_sets": 3,
      "num_set_parts": 10,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6357786.jpg",
      "elements": [
        "6357786"
      ]
    },
    {
      "color_id": 84,
      "color_name": "Medium Nougat",
      "num_sets": 7,
      "num_set_parts": 42,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6454167.jpg",
      "elements": [
        "6454167"
      ]
    },
    {
      "color_id": 85,
      "color_name": "Dark Purple",
      "num_sets": 58,
      "num_set_parts": 160,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4622176.jpg",
      "elements": [
        "4622176"
      ]
    },
    {
      "color_id": 182,
      "color_name": "Trans-Orange",
      "num_sets": 46,
      "num_set_parts": 100,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6061560.jpg",
      "elements": [
        "6061560",
        "6273154"
      ]
    },
    {
      "color_id": 212,
      "color_name": "Bright Light Blue",
      "num_sets": 1,
      "num_set_parts": 3,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6212993.jpg",
      "elements": [
        "6212993"
      ]
    },
    {
      "color_id": 226,
      "color_name": "Bright Light Yellow",
      "num_sets": 17,
      "num_set_parts": 44,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6301835.jpg",
      "elements": [
        "6301835"
      ]
    },
    {
      "color_id": 272,
      "color_name": "Dark Blue",
      "num_sets": 32,
      "num_set_parts": 235,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4505985.jpg",
      "elements": [
        "4505985"
      ]
    },
    {
      "color_id": 288,
      "color_name": "Dark Green",
      "num_sets": 1,
      "num_set_parts": 2,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6055770.jpg",
      "elements": [
        "6055770"
      ]
    },
    {
      "color_id": 320,
      "color_name": "Dark Red",
      "num_sets": 3,
      "num_set_parts": 7,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4163465.jpg",
      "elements": [
        "4163465",
        "6052785"
      ]
    },
    {
      "color_id": 321,
      "color_name": "Dark Azure",
      "num_sets": 19,
      "num_set_parts": 75,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6229071.jpg",
      "elements": [
        "6229071"
      ]
    },
    {
      "color_id": 322,
      "color_name": "Medium Azure",
      "num_sets": 20,
      "num_set_parts": 54,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6224282.jpg",
      "elements": [
        "6224282"
      ]
    },
    {
      "color_id": 323,
      "color_name": "Light Aqua",
      "num_sets": 1,
      "num_set_parts": 2,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6013704.jpg",
      "elements": [
        "6013704"
      ]
    },
    {
      "color_id": 378,
      "color_name": "Sand Green",
      "num_sets": 7,
      "num_set_parts": 49,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4156910.jpg",
      "elements": [
        "4156910",
        "6258145"
      ]
    },
    {
      "color_id": 379,
      "color_name": "Sand Blue",
      "num_sets": 1,
      "num_set_parts": 1,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4169460.jpg",
      "elements": [
        "4169460"
      ]
    },
    {
      "color_id": 383,
      "color_name": "Chrome Silver",
      "num_sets": 5,
      "num_set_parts": 20,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/ldraw/383/3941.png",
      "elements": []
    }
  ]
} 

GET /api/v3/lego/parts/{part_num}/colors/{color_id}/

{
  "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/614326.jpg",
  "year_from": 1979,
  "year_to": 2024,
  "num_sets": 433,
  "num_set_parts": 1510,
  "elements": [
    "394126",
    "614326"
  ]
} 

GET /api/v3/lego/elements/{element_id}/

{
  "part": {
    "part_num": "3941",
    "name": "Brick Round 2 x 2 with Axle Hole",
    "part_cat_id": 20,
    "year_from": 1979,
    "year_to": 2024,
    "part_url": "https://rebrickable.com/parts/3941/brick-round-2-x-2-with-axle-hole/",
    "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/614301.jpg",
    "prints": [
      "3941pr0002",
      "3941pr0004",
      "3941pr0001",
      "3941pr9999",
      "3941pr0003"
    ],
    "molds": [],
    "alternates": [],
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
    "id": 3,
    "name": "Dark Turquoise",
    "rgb": "008F9B",
    "is_trans": false,
    "external_ids": {
      "BrickLink": {
        "ext_ids": [
          39
        ],
        "ext_descrs": [
          [
            "Dark Turquoise"
          ]
        ]
      },
      "BrickOwl": {
        "ext_ids": [
          58
        ],
        "ext_descrs": [
          [
            "Dark Turquoise"
          ]
        ]
      },
      "LEGO": {
        "ext_ids": [
          107
        ],
        "ext_descrs": [
          [
            "Bright bluish green",
            "BR.BLUEGREEN"
          ]
        ]
      },
      "Peeron": {
        "ext_ids": [
          null
        ],
        "ext_descrs": [
          [
            "teal"
          ]
        ]
      },
      "LDraw": {
        "ext_ids": [
          3
        ],
        "ext_descrs": [
          [
            "Dark_Turquoise"
          ]
        ]
      }
    }
  },
  "element_id": "6290502",
  "design_id": "6143",
  "element_img_url": "https://cdn.rebrickable.com/media/parts/elements/6290502.jpg",
  "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6290502.jpg"
} 
GET parts/3941pr0001/colors
 {
  "count": 1,
  "next": null,
  "previous": null,
  "results": [
    {
      "color_id": 15,
      "color_name": "White",
      "num_sets": 1,
      "num_set_parts": 1,
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6223552.jpg",
      "elements": [
        "6223552"
      ]
    }
  ]
}*/