using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class PartCatalog
    {
        [JsonPropertyName("results")]
        public List<PartResults> Results { get; set; }

        [JsonPropertyName("next")]
        public string Next { get; set; }
    }
    public class PartResults
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("part_num")]
        public string? PartNumber { get; set; }

        [JsonPropertyName("part_img_url")]
        public string? Image { get; set; }
    }
}
/*

 GET https://rebrickable.com/api/v3/lego/parts/?search=3941pr 
{
  "count": 6,
  "next": null,
  "previous": null,
  "results": [
    {
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
    {
      "part_num": "3941pr0001",
      "name": "Brick Round 2 x 2 with DD-BD Droid print",
      "part_cat_id": 20,
      "part_url": "https://rebrickable.com/parts/3941pr0001/brick-round-2-x-2-with-dd-bd-droid-print/",
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6223552.jpg",
      "external_ids": {
        "BrickLink": [
          "3941pb20"
        ],
        "BrickOwl": [
          "964775"
        ],
        "Brickset": [
          "38211"
        ],
        "LEGO": [
          "38211"
        ]
      },
      "print_of": "3941"
    },
    {
      "part_num": "3941pr0002",
      "name": "Brick Round 2 x 2 with Buttons on Black Panel Print on Two Sides",
      "part_cat_id": 20,
      "part_url": "https://rebrickable.com/parts/3941pr0002/brick-round-2-x-2-with-buttons-on-black-panel-print-on-two-sides/",
      "part_img_url": "https://cdn.rebrickable.com/media/parts/ldraw/7/3941p01.png",
      "external_ids": {
        "BrickLink": [
          "3941p01"
        ],
        "BrickOwl": [
          "355773"
        ],
        "LDraw": [
          "3941p01"
        ]
      },
      "print_of": "3941"
    },
    {
      "part_num": "3941pr0003",
      "name": "Brick Round 2 x 2 with Axle Hole with Ghost Face Print",
      "part_cat_id": 20,
      "part_url": "https://rebrickable.com/parts/3941pr0003/brick-round-2-x-2-with-axle-hole-with-ghost-face-print/",
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6302233.jpg",
      "external_ids": {
        "BrickLink": [
          "3941pb33"
        ],
        "BrickOwl": [
          "868870"
        ],
        "Brickset": [
          "68116"
        ],
        "LEGO": [
          "68116"
        ]
      },
      "print_of": "3941"
    },
    {
      "part_num": "3941pr0004",
      "name": "Brick Round 2 x 2 with 'Octan' Print",
      "part_cat_id": 20,
      "part_url": "https://rebrickable.com/parts/3941pr0004/brick-round-2-x-2-with-octan-print/",
      "part_img_url": "https://cdn.rebrickable.com/media/parts/photos/15/3941pb01-15-3922fc3e-ef59-47bb-83d3-186774b72ec2.jpg",
      "external_ids": {
        "BrickLink": [
          "3941pb01"
        ],
        "BrickOwl": [
          "158503"
        ]
      },
      "print_of": "3941"
    },
    {
      "part_num": "3941pr9999",
      "name": "Brick Round 2 x 2 with Axle Hole, Red and Dark Red Eye Print",
      "part_cat_id": 20,
      "part_url": "https://rebrickable.com/parts/3941pr9999/brick-round-2-x-2-with-axle-hole-red-and-dark-red-eye-print/",
      "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6404665.jpg",
      "external_ids": {
        "BrickLink": [
          "3941pb45"
        ],
        "BrickOwl": [
          "1262035"
        ],
        "Brickset": [
          "100436"
        ],
        "LDraw": [
          "3941p02"
        ],
        "LEGO": [
          "100436"
        ]
      },
      "print_of": "3941"
    }
  ]
}*/