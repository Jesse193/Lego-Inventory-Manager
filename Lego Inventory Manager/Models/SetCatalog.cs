using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class SetCatalog
    {
        [JsonPropertyName("results")]
        public List<SetResults> Results { get; set; }

        [JsonPropertyName("next")]
        public string Next { get; set; }
    }

    public class SetResults
    {
        [JsonPropertyName("set_num")]
        public string SetNumber { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("num_parts")]
        public int NumParts { get; set; }

        [JsonPropertyName("set_img_url")]
        public string Image { get; set; }
    }

    public class SetShow
    {
        [JsonPropertyName("count")]
        public int PartCount { get; set; }

        [JsonPropertyName("results")]
        public List<SetPartList> Results { get; set; }
    }

    public class SetPartList
    {
        [JsonPropertyName("part")]
        public SetPart SetPart { get; set; }

        [JsonPropertyName("color")]
        public SetPartColor SetPartColor { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("element_id")]
        public string ElementId { get; set; }

        [JsonPropertyName("is_spare")]
        public bool IsSpare { get; set; }
    }

    public class SetPart
    {
        [JsonPropertyName("part_num")]
        public string PartNumber { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("part_img_url")]
        public string PartImage { get; set; }
    }

    public class SetPartColor
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
/*
{
  "count": 129,
  "next": "https://rebrickable.com/api/v3/lego/sets/75333-1/parts/?page=2",
  "previous": null,
  "results": [
    {
        "id": 13528615,
      "inv_part_id": 13528615,
      "part": {
            "part_num": "54662",
        "name": "Hinge Cylinder 1 x 3 Locking with 1 Finger and 2 Fingers On Ends, with Hole, 7 Teeth",
        "part_cat_id": 18,
        "part_url": "https://rebrickable.com/parts/54662/hinge-cylinder-1-x-3-locking-with-1-finger-and-2-fingers-on-ends-with-hole-7-teeth/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6267110.jpg",
        "external_ids": {
                "BrickLink": [
                  "30554b"
          ],
          "BrickOwl": [
            "997529"
          ],
          "Brickset": [
            "54662"
          ],
          "LDraw": [
            "54662"
          ],
          "LEGO": [
            "54662"
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
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6267110",
      "num_sets": 9
    },
    {
        "id": 13528609,
      "inv_part_id": 13528609,
      "part": {
            "part_num": "50340",
        "name": "Hinge Plate 1 x 2 Locking with 2 Fingers on Side, 7 Teeth",
        "part_cat_id": 18,
        "part_url": "https://rebrickable.com/parts/50340/hinge-plate-1-x-2-locking-with-2-fingers-on-side-7-teeth/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6266207.jpg",
        "external_ids": {
                "BrickLink": [
                  "60471"
          ],
          "BrickOwl": [
            "912792"
          ],
          "Brickset": [
            "50340"
          ],
          "LDraw": [
            "50340"
          ],
          "LEGO": [
            "50340"
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
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6266207",
      "num_sets": 39
    },
    {
        "id": 13528604,
      "inv_part_id": 13528604,
      "part": {
            "part_num": "44300",
        "name": "Hinge Tile 1 x 3 Locking with 1 Finger on Top",
        "part_cat_id": 18,
        "part_url": "https://rebrickable.com/parts/44300/hinge-tile-1-x-3-locking-with-1-finger-on-top/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4183028.jpg",
        "external_ids": {
                "BrickLink": [
                  "44300"
          ],
          "BrickOwl": [
            "187321"
          ],
          "Brickset": [
            "44300"
          ],
          "LDraw": [
            "44300"
          ],
          "LEGO": [
            "44300"
          ],
          "Peeron": [
            "x782"
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
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "4296142",
      "num_sets": 25
    },
    {
        "id": 13528560,
      "inv_part_id": 13528560,
      "part": {
            "part_num": "3024",
        "name": "Plate 1 x 1",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3024/plate-1-x-1/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/302426.jpg",
        "external_ids": {
                "BrickLink": [
                  "3024"
          ],
          "BrickOwl": [
            "322944"
          ],
          "Brickset": [
            "28554",
            "30008",
            "3024",
            "63326"
          ],
          "LDraw": [
            "3024"
          ],
          "LEGO": [
            "28554",
            "30008",
            "3024",
            "63326"
          ],
          "Peeron": [
            "30008"
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
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "302426",
      "num_sets": 1100
    },
    {
        "id": 13972013,
      "inv_part_id": 13972013,
      "part": {
            "part_num": "3024",
        "name": "Plate 1 x 1",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3024/plate-1-x-1/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/302426.jpg",
        "external_ids": {
                "BrickLink": [
                  "3024"
          ],
          "BrickOwl": [
            "322944"
          ],
          "Brickset": [
            "28554",
            "30008",
            "3024",
            "63326"
          ],
          "LDraw": [
            "3024"
          ],
          "LEGO": [
            "28554",
            "30008",
            "3024",
            "63326"
          ],
          "Peeron": [
            "30008"
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
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": true,
      "element_id": "302426",
      "num_sets": 1100
    },
    {
        "id": 13528579,
      "inv_part_id": 13528579,
      "part": {
            "part_num": "3623",
        "name": "Plate 1 x 3",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3623/plate-1-x-3/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/362326.jpg",
        "external_ids": {
                "BrickLink": [
                  "3623"
          ],
          "BrickOwl": [
            "212990"
          ],
          "Brickset": [
            "3623"
          ],
          "LDraw": [
            "3623"
          ],
          "LEGO": [
            "3623"
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
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "362326",
      "num_sets": 1083
    },
    {
        "id": 13528551,
      "inv_part_id": 13528551,
      "part": {
            "part_num": "3021",
        "name": "Plate 2 x 3",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3021/plate-2-x-3/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/302126.jpg",
        "external_ids": {
                "BrickLink": [
                  "3021"
          ],
          "BrickOwl": [
            "960521"
          ],
          "Brickset": [
            "3021"
          ],
          "LDraw": [
            "3021"
          ],
          "LEGO": [
            "3021"
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
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "302126",
      "num_sets": 1560
    },
    {
        "id": 13528589,
      "inv_part_id": 13528589,
      "part": {
            "part_num": "3795",
        "name": "Plate 2 x 6",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3795/plate-2-x-6/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/379526.jpg",
        "external_ids": {
                "BrickLink": [
                  "3795"
          ],
          "BrickOwl": [
            "735504"
          ],
          "Brickset": [
            "3795"
          ],
          "LDraw": [
            "3795"
          ],
          "LEGO": [
            "3795"
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
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "379526",
      "num_sets": 1371
    },
    {
        "id": 13528563,
      "inv_part_id": 13528563,
      "part": {
            "part_num": "3031",
        "name": "Plate 4 x 4",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3031/plate-4-x-4/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/303126.jpg",
        "external_ids": {
                "BrickLink": [
                  "3031"
          ],
          "BrickOwl": [
            "163746"
          ],
          "Brickset": [
            "3031"
          ],
          "LDraw": [
            "3031"
          ],
          "LEGO": [
            "3031"
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
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "4243819",
      "num_sets": 681
    },
    {
        "id": 13528593,
      "inv_part_id": 13528593,
      "part": {
            "part_num": "4032a",
        "name": "Plate Round 2 x 2 with Axle Hole Type 1 (+ Opening)",
        "part_cat_id": 21,
        "part_url": "https://rebrickable.com/parts/4032a/plate-round-2-x-2-with-axle-hole-type-1-opening/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/403226.jpg",
        "external_ids": {
                "BrickLink": [
                  "4032"
          ],
          "BrickOwl": [
            "680648"
          ],
          "Brickset": [
            "4032"
          ],
          "LDraw": [
            "4032a"
          ],
          "LEGO": [
            "4032"
          ],
          "Peeron": [
            "4032"
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
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "403226",
      "num_sets": 878
    },
    {
        "id": 13528619,
      "inv_part_id": 13528619,
      "part": {
            "part_num": "61252",
        "name": "Plate Special 1 x 1 with Clip Horizontal [Thick Open O Clip]",
        "part_cat_id": 9,
        "part_url": "https://rebrickable.com/parts/61252/plate-special-1-x-1-with-clip-horizontal-thick-open-o-clip/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6308000.jpg",
        "external_ids": {
                "BrickLink": [
                  "61252"
          ],
          "BrickOwl": [
            "380889"
          ],
          "Brickset": [
            "52738",
            "61252"
          ],
          "LDraw": [
            "61252"
          ],
          "LEGO": [
            "52738",
            "61252"
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
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6308000",
      "num_sets": 316
    },
    {
        "id": 13528531,
      "inv_part_id": 13528531,
      "part": {
            "part_num": "18677",
        "name": "Plate Special 1 x 2 with Pin Hole Underneath",
        "part_cat_id": 9,
        "part_url": "https://rebrickable.com/parts/18677/plate-special-1-x-2-with-pin-hole-underneath/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6167497.jpg",
        "external_ids": {
                "BrickLink": [
                  "18677"
          ],
          "BrickOwl": [
            "612598"
          ],
          "Brickset": [
            "18677",
            "28809"
          ],
          "LDraw": [
            "18677",
            "28809"
          ],
          "LEGO": [
            "18677",
            "28809"
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
        },
      "set_num": "75333-1",
      "quantity": 6,
      "is_spare": false,
      "element_id": "6192309",
      "num_sets": 138
    },
    {
        "id": 13528597,
      "inv_part_id": 13528597,
      "part": {
            "part_num": "41740",
        "name": "Plate Special 1 x 4 with 2 Studs with Groove [New Underside]",
        "part_cat_id": 9,
        "part_url": "https://rebrickable.com/parts/41740/plate-special-1-x-4-with-2-studs-with-groove-new-underside/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6254045.jpg",
        "external_ids": {
                "BrickLink": [
                  "41740"
          ],
          "BrickOwl": [
            "706084"
          ],
          "Brickset": [
            "41740"
          ],
          "LDraw": [
            "41740"
          ],
          "LEGO": [
            "41740"
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
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6254045",
      "num_sets": 196
    },
    {
        "id": 13528576,
      "inv_part_id": 13528576,
      "part": {
            "part_num": "33909",
        "name": "Plate Special 2 x 2 with Only 2 studs",
        "part_cat_id": 9,
        "part_url": "https://rebrickable.com/parts/33909/plate-special-2-x-2-with-only-2-studs/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6192346.jpg",
        "external_ids": {
                "BrickLink": [
                  "33909"
          ],
          "BrickOwl": [
            "329884"
          ],
          "Brickset": [
            "100767",
            "33909"
          ],
          "LDraw": [
            "33909"
          ],
          "LEGO": [
            "100767",
            "33909"
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
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6192346",
      "num_sets": 232
    },
    {
        "id": 13528583,
      "inv_part_id": 13528583,
      "part": {
            "part_num": "76959",
        "name": "Slope Inverted 45° 2 x 2 [Round Hollow Bottom Pin, Bar-sized Stud Holes]",
        "part_cat_id": 3,
        "part_url": "https://rebrickable.com/parts/76959/slope-inverted-45-2-x-2-round-hollow-bottom-pin-bar-sized-stud-holes/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6425507.jpg",
        "external_ids": {
                "BrickLink": [
                  "76959"
          ],
          "BrickOwl": [
            "1273361"
          ],
          "Brickset": [
            "76959"
          ],
          "LDraw": [
            "76959"
          ],
          "LEGO": [
            "76959"
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
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6425507",
      "num_sets": 51
    },
    {
        "id": 13528574,
      "inv_part_id": 13528574,
      "part": {
            "part_num": "32062",
        "name": "Technic Axle 2 Notched",
        "part_cat_id": 46,
        "part_url": "https://rebrickable.com/parts/32062/technic-axle-2-notched/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4109810.jpg",
        "external_ids": {
                "BrickLink": [
                  "32062"
          ],
          "BrickOwl": [
            "515411"
          ],
          "Brickset": [
            "32062"
          ],
          "LDraw": [
            "32062"
          ],
          "LEGO": [
            "32062"
          ],
          "Peeron": [
            "3704a"
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
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "4109810",
      "num_sets": 821
    },
    {
        "id": 13528587,
      "inv_part_id": 13528587,
      "part": {
            "part_num": "3705",
        "name": "Technic Axle 4",
        "part_cat_id": 46,
        "part_url": "https://rebrickable.com/parts/3705/technic-axle-4/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/370526.jpg",
        "external_ids": {
                "BrickLink": [
                  "3705"
          ],
          "BrickOwl": [
            "184264"
          ],
          "Brickset": [
            "3705"
          ],
          "LDraw": [
            "3705"
          ],
          "LEGO": [
            "3705"
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
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "370526",
      "num_sets": 1496
    },
    {
        "id": 13528573,
      "inv_part_id": 13528573,
      "part": {
            "part_num": "32016",
        "name": "Technic Axle and Pin Connector Angled #3 - 157.5°",
        "part_cat_id": 12,
        "part_url": "https://rebrickable.com/parts/32016/technic-axle-and-pin-connector-angled-3-1575/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4107082.jpg",
        "external_ids": {
                "BrickLink": [
                  "32016"
          ],
          "BrickOwl": [
            "341421"
          ],
          "Brickset": [
            "32016",
            "42128"
          ],
          "LDraw": [
            "32016"
          ],
          "LEGO": [
            "32016",
            "42128"
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
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "6261386",
      "num_sets": 244
    },
    {
        "id": 13972019,
      "inv_part_id": 13972019,
      "part": {
            "part_num": "61332",
        "name": "Technic Pin with Friction Ridges Lengthwise with No Center Slots",
        "part_cat_id": 53,
        "part_url": "https://rebrickable.com/parts/61332/technic-pin-with-friction-ridges-lengthwise-with-no-center-slots/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6279875.jpg",
        "external_ids": {
                "BrickLink": [
                  "2780"
          ],
          "BrickOwl": [
            "33899"
          ],
          "Brickset": [
            "61332"
          ],
          "LDraw": [
            "61332"
          ],
          "LEGO": [
            "61332"
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
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": true,
      "element_id": "6279875",
      "num_sets": 582
    },
    {
        "id": 13528621,
      "inv_part_id": 13528621,
      "part": {
            "part_num": "61332",
        "name": "Technic Pin with Friction Ridges Lengthwise with No Center Slots",
        "part_cat_id": 53,
        "part_url": "https://rebrickable.com/parts/61332/technic-pin-with-friction-ridges-lengthwise-with-no-center-slots/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6279875.jpg",
        "external_ids": {
                "BrickLink": [
                  "2780"
          ],
          "BrickOwl": [
            "33899"
          ],
          "Brickset": [
            "61332"
          ],
          "LDraw": [
            "61332"
          ],
          "LEGO": [
            "61332"
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
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6279875",
      "num_sets": 582
    },
    {
        "id": 13528535,
      "inv_part_id": 13528535,
      "part": {
            "part_num": "2412b",
        "name": "Tile Special 1 x 2 Grille with Bottom Groove",
        "part_cat_id": 15,
        "part_url": "https://rebrickable.com/parts/2412b/tile-special-1-x-2-grille-with-bottom-groove/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/241226.jpg",
        "external_ids": {
                "BrickLink": [
                  "2412b"
          ],
          "BrickOwl": [
            "363948"
          ],
          "Brickset": [
            "15561",
            "2412",
            "30244",
            "35248",
            "51815",
            "71957",
            "78812"
          ],
          "LDraw": [
            "2412b",
            "30244"
          ],
          "LEGO": [
            "15561",
            "2412",
            "30244",
            "35248",
            "51815",
            "71957",
            "78812"
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
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "241226",
      "num_sets": 994
    },
    {
        "id": 13528540,
      "inv_part_id": 13528540,
      "part": {
            "part_num": "2432",
        "name": "Tile Special 1 x 2 with Handle",
        "part_cat_id": 15,
        "part_url": "https://rebrickable.com/parts/2432/tile-special-1-x-2-with-handle/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/243226.jpg",
        "external_ids": {
                "BrickLink": [
                  "2432"
          ],
          "BrickOwl": [
            "765452"
          ],
          "Brickset": [
            "2432"
          ],
          "LDraw": [
            "2432"
          ],
          "LEGO": [
            "2432"
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
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "243226",
      "num_sets": 395
    },
    {
        "id": 13528586,
      "inv_part_id": 13528586,
      "part": {
            "part_num": "3680",
        "name": "Turntable 2 x 2 Plate, Base",
        "part_cat_id": 18,
        "part_url": "https://rebrickable.com/parts/3680/turntable-2-x-2-plate-base/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/368026.jpg",
        "external_ids": {
                "BrickLink": [
                  "3680"
          ],
          "BrickOwl": [
            "306217"
          ],
          "Brickset": [
            "3680"
          ],
          "LDraw": [
            "3680"
          ],
          "LEGO": [
            "3680"
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
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "368076",
      "num_sets": 546
    },
    {
        "id": 13528608,
      "inv_part_id": 13528608,
      "part": {
            "part_num": "50305",
        "name": "Wedge Plate 8 x 3, 22° Left",
        "part_cat_id": 49,
        "part_url": "https://rebrickable.com/parts/50305/wedge-plate-8-x-3-22-left/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4251394.jpg",
        "external_ids": {
                "BrickLink": [
                  "50305"
          ],
          "BrickOwl": [
            "951859"
          ],
          "Brickset": [
            "50305"
          ],
          "LDraw": [
            "50305"
          ],
          "LEGO": [
            "50305"
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
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "4251394",
      "num_sets": 66
    },
    {
        "id": 13528607,
      "inv_part_id": 13528607,
      "part": {
            "part_num": "50304",
        "name": "Wedge Plate 8 x 3, 22° Right",
        "part_cat_id": 49,
        "part_url": "https://rebrickable.com/parts/50304/wedge-plate-8-x-3-22-right/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4251393.jpg",
        "external_ids": {
                "BrickLink": [
                  "50304"
          ],
          "BrickOwl": [
            "529202"
          ],
          "Brickset": [
            "50304"
          ],
          "LDraw": [
            "50304"
          ],
          "LEGO": [
            "50304"
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
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "4251393",
      "num_sets": 66
    },
    {
        "id": 13528600,
      "inv_part_id": 13528600,
      "part": {
            "part_num": "42924",
        "name": "Technic Pin Long with Friction Ridges Lengthwise, 1 Center Slot",
        "part_cat_id": 53,
        "part_url": "https://rebrickable.com/parts/42924/technic-pin-long-with-friction-ridges-lengthwise-1-center-slot/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6299413.jpg",
        "external_ids": {
                "BrickLink": [
                  "6558"
          ],
          "BrickOwl": [
            "99899"
          ],
          "Brickset": [
            "42924"
          ],
          "LDraw": [
            "42924"
          ],
          "LEGO": [
            "42924"
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
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6299413",
      "num_sets": 296
    },
    {
        "id": 13528644,
      "inv_part_id": 13528644,
      "part": {
            "part_num": "92947",
        "name": "Brick Round 2 x 2 [Grill]",
        "part_cat_id": 20,
        "part_url": "https://rebrickable.com/parts/92947/brick-round-2-x-2-grill/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6268169.jpg",
        "external_ids": {
                "BrickLink": [
                  "92947"
          ],
          "BrickOwl": [
            "947319"
          ],
          "Brickset": [
            "92947"
          ],
          "LDraw": [
            "92947"
          ],
          "LEGO": [
            "92947"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 72,
        "name": "Dark Bluish Gray",
        "rgb": "6C6E68",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      85
                  ],
            "ext_descrs": [
              [
                "Dark Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      50
            ],
            "ext_descrs": [
              [
                "Dark Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      199
            ],
            "ext_descrs": [
              [
                "Dark stone grey",
                "DK. ST. GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      72
            ],
            "ext_descrs": [
              [
                "Dark_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6268169",
      "num_sets": 25
    },
    {
        "id": 13528606,
      "inv_part_id": 13528606,
      "part": {
            "part_num": "4740",
        "name": "Dish 2 x 2 Inverted [Radar]",
        "part_cat_id": 21,
        "part_url": "https://rebrickable.com/parts/4740/dish-2-x-2-inverted-radar/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4211010.jpg",
        "external_ids": {
                "BrickLink": [
                  "4740"
          ],
          "BrickOwl": [
            "739988"
          ],
          "Brickset": [
            "17964",
            "30063",
            "35395",
            "4740",
            "64938",
            "71874"
          ],
          "LDraw": [
            "4740"
          ],
          "LEGO": [
            "17964",
            "30063",
            "35395",
            "4740",
            "64938",
            "71874"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 72,
        "name": "Dark Bluish Gray",
        "rgb": "6C6E68",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      85
                  ],
            "ext_descrs": [
              [
                "Dark Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      50
            ],
            "ext_descrs": [
              [
                "Dark Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      199
            ],
            "ext_descrs": [
              [
                "Dark stone grey",
                "DK. ST. GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      72
            ],
            "ext_descrs": [
              [
                "Dark_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "4211010",
      "num_sets": 208
    },
    {
        "id": 13972016,
      "inv_part_id": 13972016,
      "part": {
            "part_num": "69755",
        "name": "Launcher Trigger, Weapon Gun Trigger",
        "part_cat_id": 68,
        "part_url": "https://rebrickable.com/parts/69755/launcher-trigger-weapon-gun-trigger/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6360675.jpg",
        "external_ids": {
                "BrickLink": [
                  "69755"
          ],
          "BrickOwl": [
            "1265802"
          ],
          "Brickset": [
            "69755"
          ],
          "LDraw": [
            "69755"
          ],
          "LEGO": [
            "69755"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 72,
        "name": "Dark Bluish Gray",
        "rgb": "6C6E68",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      85
                  ],
            "ext_descrs": [
              [
                "Dark Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      50
            ],
            "ext_descrs": [
              [
                "Dark Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      199
            ],
            "ext_descrs": [
              [
                "Dark stone grey",
                "DK. ST. GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      72
            ],
            "ext_descrs": [
              [
                "Dark_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": true,
      "element_id": "6360675",
      "num_sets": 97
    },
    {
        "id": 13528634,
      "inv_part_id": 13528634,
      "part": {
            "part_num": "69755",
        "name": "Launcher Trigger, Weapon Gun Trigger",
        "part_cat_id": 68,
        "part_url": "https://rebrickable.com/parts/69755/launcher-trigger-weapon-gun-trigger/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6360675.jpg",
        "external_ids": {
                "BrickLink": [
                  "69755"
          ],
          "BrickOwl": [
            "1265802"
          ],
          "Brickset": [
            "69755"
          ],
          "LDraw": [
            "69755"
          ],
          "LEGO": [
            "69755"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 72,
        "name": "Dark Bluish Gray",
        "rgb": "6C6E68",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      85
                  ],
            "ext_descrs": [
              [
                "Dark Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      50
            ],
            "ext_descrs": [
              [
                "Dark Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      199
            ],
            "ext_descrs": [
              [
                "Dark stone grey",
                "DK. ST. GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      72
            ],
            "ext_descrs": [
              [
                "Dark_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6360675",
      "num_sets": 97
    },
    {
        "id": 13528552,
      "inv_part_id": 13528552,
      "part": {
            "part_num": "3021",
        "name": "Plate 2 x 3",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3021/plate-2-x-3/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4211043.jpg",
        "external_ids": {
                "BrickLink": [
                  "3021"
          ],
          "BrickOwl": [
            "960521"
          ],
          "Brickset": [
            "3021"
          ],
          "LDraw": [
            "3021"
          ],
          "LEGO": [
            "3021"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 72,
        "name": "Dark Bluish Gray",
        "rgb": "6C6E68",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      85
                  ],
            "ext_descrs": [
              [
                "Dark Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      50
            ],
            "ext_descrs": [
              [
                "Dark Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      199
            ],
            "ext_descrs": [
              [
                "Dark stone grey",
                "DK. ST. GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      72
            ],
            "ext_descrs": [
              [
                "Dark_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "4211043",
      "num_sets": 925
    },
    {
        "id": 13528594,
      "inv_part_id": 13528594,
      "part": {
            "part_num": "4032a",
        "name": "Plate Round 2 x 2 with Axle Hole Type 1 (+ Opening)",
        "part_cat_id": 21,
        "part_url": "https://rebrickable.com/parts/4032a/plate-round-2-x-2-with-axle-hole-type-1-opening/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4211042.jpg",
        "external_ids": {
                "BrickLink": [
                  "4032"
          ],
          "BrickOwl": [
            "680648"
          ],
          "Brickset": [
            "4032"
          ],
          "LDraw": [
            "4032a"
          ],
          "LEGO": [
            "4032"
          ],
          "Peeron": [
            "4032"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 72,
        "name": "Dark Bluish Gray",
        "rgb": "6C6E68",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      85
                  ],
            "ext_descrs": [
              [
                "Dark Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      50
            ],
            "ext_descrs": [
              [
                "Dark Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      199
            ],
            "ext_descrs": [
              [
                "Dark stone grey",
                "DK. ST. GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      72
            ],
            "ext_descrs": [
              [
                "Dark_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "4211042",
      "num_sets": 565
    },
    {
        "id": 13528639,
      "inv_part_id": 13528639,
      "part": {
            "part_num": "85984pr0006",
        "name": "Slope 30° 1 x 2 x 2/3 with Buttons And Red Screens Print",
        "part_cat_id": 3,
        "part_url": "https://rebrickable.com/parts/85984pr0006/slope-30-1-x-2-x-23-with-buttons-and-red-screens-print/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6152814.jpg",
        "external_ids": {
                "BrickLink": [
                  "85984pb127"
          ],
          "BrickOwl": [
            "457457"
          ],
          "Brickset": [
            "26823"
          ],
          "LDraw": [
            "85984ps1"
          ],
          "LEGO": [
            "26823"
          ]
        },
        "print_of": "85984"
      },
      "color": {
            "id": 72,
        "name": "Dark Bluish Gray",
        "rgb": "6C6E68",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      85
                  ],
            "ext_descrs": [
              [
                "Dark Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      50
            ],
            "ext_descrs": [
              [
                "Dark Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      199
            ],
            "ext_descrs": [
              [
                "Dark stone grey",
                "DK. ST. GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      72
            ],
            "ext_descrs": [
              [
                "Dark_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6152814",
      "num_sets": 107
    },
    {
        "id": 13528522,
      "inv_part_id": 13528522,
      "part": {
            "part_num": "11214",
        "name": "Technic Axle Pin 3L with Friction Ridges Lengthwise and 1L Axle",
        "part_cat_id": 53,
        "part_url": "https://rebrickable.com/parts/11214/technic-axle-pin-3l-with-friction-ridges-lengthwise-and-1l-axle/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6015356.jpg",
        "external_ids": {
                "BrickLink": [
                  "11214"
          ],
          "BrickOwl": [
            "102238"
          ],
          "Brickset": [
            "11214"
          ],
          "LDraw": [
            "11214"
          ],
          "LEGO": [
            "11214"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 72,
        "name": "Dark Bluish Gray",
        "rgb": "6C6E68",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      85
                  ],
            "ext_descrs": [
              [
                "Dark Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      50
            ],
            "ext_descrs": [
              [
                "Dark Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      199
            ],
            "ext_descrs": [
              [
                "Dark stone grey",
                "DK. ST. GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      72
            ],
            "ext_descrs": [
              [
                "Dark_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "6015356",
      "num_sets": 372
    },
    {
        "id": 13528561,
      "inv_part_id": 13528561,
      "part": {
            "part_num": "3024",
        "name": "Plate 1 x 1",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3024/plate-1-x-1/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4183901.jpg",
        "external_ids": {
                "BrickLink": [
                  "3024"
          ],
          "BrickOwl": [
            "322944"
          ],
          "Brickset": [
            "28554",
            "30008",
            "3024",
            "63326"
          ],
          "LDraw": [
            "3024"
          ],
          "LEGO": [
            "28554",
            "30008",
            "3024",
            "63326"
          ],
          "Peeron": [
            "30008"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "4539114",
      "num_sets": 181
    },
    {
        "id": 13972014,
      "inv_part_id": 13972014,
      "part": {
            "part_num": "3024",
        "name": "Plate 1 x 1",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3024/plate-1-x-1/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4183901.jpg",
        "external_ids": {
                "BrickLink": [
                  "3024"
          ],
          "BrickOwl": [
            "322944"
          ],
          "Brickset": [
            "28554",
            "30008",
            "3024",
            "63326"
          ],
          "LDraw": [
            "3024"
          ],
          "LEGO": [
            "28554",
            "30008",
            "3024",
            "63326"
          ],
          "Peeron": [
            "30008"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": true,
      "element_id": "4539114",
      "num_sets": 181
    },
    {
        "id": 13528557,
      "inv_part_id": 13528557,
      "part": {
            "part_num": "3023",
        "name": "Plate 1 x 2",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3023/plate-1-x-2/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4162582.jpg",
        "external_ids": {
                "BrickLink": [
                  "3023"
          ],
          "BrickOwl": [
            "44980"
          ],
          "Brickset": [
            "28653",
            "3023",
            "6225"
          ],
          "LDraw": [
            "28653",
            "3023",
            "3023b"
          ],
          "LEGO": [
            "28653",
            "3023",
            "6225"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "4539097",
      "num_sets": 327
    },
    {
        "id": 13528580,
      "inv_part_id": 13528580,
      "part": {
            "part_num": "3623",
        "name": "Plate 1 x 3",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3623/plate-1-x-3/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4164223.jpg",
        "external_ids": {
                "BrickLink": [
                  "3623"
          ],
          "BrickOwl": [
            "212990"
          ],
          "Brickset": [
            "3623"
          ],
          "LDraw": [
            "3623"
          ],
          "LEGO": [
            "3623"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "4539076",
      "num_sets": 121
    },
    {
        "id": 13528554,
      "inv_part_id": 13528554,
      "part": {
            "part_num": "3022",
        "name": "Plate 2 x 2",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3022/plate-2-x-2/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4163160.jpg",
        "external_ids": {
                "BrickLink": [
                  "3022"
          ],
          "BrickOwl": [
            "566026"
          ],
          "Brickset": [
            "3022",
            "94148"
          ],
          "LDraw": [
            "3022",
            "94148"
          ],
          "LEGO": [
            "3022",
            "94148"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "4585479",
      "num_sets": 143
    },
    {
        "id": 13528549,
      "inv_part_id": 13528549,
      "part": {
            "part_num": "3020",
        "name": "Plate 2 x 4",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3020/plate-2-x-4/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4248803.jpg",
        "external_ids": {
                "BrickLink": [
                  "3020"
          ],
          "BrickOwl": [
            "80025"
          ],
          "Brickset": [
            "3020"
          ],
          "LDraw": [
            "3020"
          ],
          "LEGO": [
            "3020"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "4539071",
      "num_sets": 176
    },
    {
        "id": 13528590,
      "inv_part_id": 13528590,
      "part": {
            "part_num": "3795",
        "name": "Plate 2 x 6",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3795/plate-2-x-6/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4164177.jpg",
        "external_ids": {
                "BrickLink": [
                  "3795"
          ],
          "BrickOwl": [
            "735504"
          ],
          "Brickset": [
            "3795"
          ],
          "LDraw": [
            "3795"
          ],
          "LEGO": [
            "3795"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 5,
      "is_spare": false,
      "element_id": "4618986",
      "num_sets": 83
    },
    {
        "id": 13528631,
      "inv_part_id": 13528631,
      "part": {
            "part_num": "68568",
        "name": "Plate Round Corner 3 x 3 with 2 x 2 Round Cutout",
        "part_cat_id": 21,
        "part_url": "https://rebrickable.com/parts/68568/plate-round-corner-3-x-3-with-2-x-2-round-cutout/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6383988.jpg",
        "external_ids": {
                "BrickLink": [
                  "68568"
          ],
          "BrickOwl": [
            "518532"
          ],
          "Brickset": [
            "68568"
          ],
          "LDraw": [
            "68568"
          ],
          "LEGO": [
            "68568"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6383988",
      "num_sets": 4
    },
    {
        "id": 13528527,
      "inv_part_id": 13528527,
      "part": {
            "part_num": "15573",
        "name": "Plate Special 1 x 2 with 1 Stud with Groove and Inside Stud Holder (Jumper)",
        "part_cat_id": 9,
        "part_url": "https://rebrickable.com/parts/15573/plate-special-1-x-2-with-1-stud-with-groove-and-inside-stud-holder-jumper/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6092597.jpg",
        "external_ids": {
                "BrickLink": [
                  "15573"
          ],
          "BrickOwl": [
            "893367"
          ],
          "Brickset": [
            "15573",
            "78823"
          ],
          "LDraw": [
            "15573"
          ],
          "LEGO": [
            "15573",
            "78823"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "6092597",
      "num_sets": 95
    },
    {
        "id": 13528610,
      "inv_part_id": 13528610,
      "part": {
            "part_num": "54200",
        "name": "Slope 30° 1 x 1 x 2/3 (Cheese Slope)",
        "part_cat_id": 3,
        "part_url": "https://rebrickable.com/parts/54200/slope-30-1-x-1-x-23-cheese-slope/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4531415.jpg",
        "external_ids": {
                "BrickLink": [
                  "54200"
          ],
          "BrickOwl": [
            "158788"
          ],
          "Brickset": [
            "18862",
            "33847",
            "35338",
            "50746",
            "54200",
            "63290"
          ],
          "LDraw": [
            "54200"
          ],
          "LEGO": [
            "18862",
            "33847",
            "35338",
            "50746",
            "54200",
            "63290"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 3,
      "is_spare": false,
      "element_id": "4531415",
      "num_sets": 134
    },
    {
        "id": 13972020,
      "inv_part_id": 13972020,
      "part": {
            "part_num": "54200",
        "name": "Slope 30° 1 x 1 x 2/3 (Cheese Slope)",
        "part_cat_id": 3,
        "part_url": "https://rebrickable.com/parts/54200/slope-30-1-x-1-x-23-cheese-slope/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4531415.jpg",
        "external_ids": {
                "BrickLink": [
                  "54200"
          ],
          "BrickOwl": [
            "158788"
          ],
          "Brickset": [
            "18862",
            "33847",
            "35338",
            "50746",
            "54200",
            "63290"
          ],
          "LDraw": [
            "54200"
          ],
          "LEGO": [
            "18862",
            "33847",
            "35338",
            "50746",
            "54200",
            "63290"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": true,
      "element_id": "4531415",
      "num_sets": 134
    },
    {
        "id": 13528618,
      "inv_part_id": 13528618,
      "part": {
            "part_num": "60481",
        "name": "Slope 65° 2 x 1 x 2",
        "part_cat_id": 3,
        "part_url": "https://rebrickable.com/parts/60481/slope-65-2-x-1-x-2/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4645101.jpg",
        "external_ids": {
                "BrickLink": [
                  "60481"
          ],
          "BrickOwl": [
            "91632"
          ],
          "Brickset": [
            "60481"
          ],
          "LDraw": [
            "60481",
            "60481a"
          ],
          "LEGO": [
            "60481"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6287971",
      "num_sets": 15
    },
    {
        "id": 13528524,
      "inv_part_id": 13528524,
      "part": {
            "part_num": "11477",
        "name": "Slope Curved 2 x 1 No Studs [1/2 Bow]",
        "part_cat_id": 37,
        "part_url": "https://rebrickable.com/parts/11477/slope-curved-2-x-1-no-studs-12-bow/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6173168.jpg",
        "external_ids": {
                "BrickLink": [
                  "11477"
          ],
          "BrickOwl": [
            "910030"
          ],
          "Brickset": [
            "11477",
            "17134",
            "3593",
            "67128"
          ],
          "LDraw": [
            "11477"
          ],
          "LEGO": [
            "11477",
            "17134",
            "3593",
            "67128"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6173168",
      "num_sets": 75
    },
    {
        "id": 13528570,
      "inv_part_id": 13528570,
      "part": {
            "part_num": "3069b",
        "name": "Tile 1 x 2 with Groove",
        "part_cat_id": 19,
        "part_url": "https://rebrickable.com/parts/3069b/tile-1-x-2-with-groove/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4165783.jpg",
        "external_ids": {
                "BrickLink": [
                  "3069"
          ],
          "BrickOwl": [
            "487300"
          ],
          "Brickset": [
            "30070",
            "3069",
            "35386",
            "37293",
            "45880",
            "54285",
            "63286"
          ],
          "LDraw": [
            "3069b"
          ],
          "LEGO": [
            "15598",
            "30070",
            "3069",
            "35386",
            "37293",
            "45880",
            "54285",
            "59489",
            "63286"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "4539090",
      "num_sets": 178
    },
    {
        "id": 13528624,
      "inv_part_id": 13528624,
      "part": {
            "part_num": "63864",
        "name": "Tile 1 x 3",
        "part_cat_id": 19,
        "part_url": "https://rebrickable.com/parts/63864/tile-1-x-3/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4583299.jpg",
        "external_ids": {
                "BrickLink": [
                  "63864"
          ],
          "BrickOwl": [
            "276668"
          ],
          "Brickset": [
            "37294",
            "63864"
          ],
          "LDraw": [
            "63864"
          ],
          "LEGO": [
            "37294",
            "63864"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "4583299",
      "num_sets": 71
    },
    {
        "id": 13528537,
      "inv_part_id": 13528537,
      "part": {
            "part_num": "2431",
        "name": "Tile 1 x 4 with Groove",
        "part_cat_id": 19,
        "part_url": "https://rebrickable.com/parts/2431/tile-1-x-4-with-groove/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4164220.jpg",
        "external_ids": {
                "BrickLink": [
                  "2431"
          ],
          "BrickOwl": [
            "853045"
          ],
          "Brickset": [
            "100687",
            "2431",
            "35371",
            "75703",
            "91143"
          ],
          "LDraw": [
            "2431"
          ],
          "LEGO": [
            "100687",
            "2431",
            "35371",
            "75703",
            "91143"
          ],
          "Peeron": [
            "2431b"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "4539060",
      "num_sets": 143
    },
    {
        "id": 13528596,
      "inv_part_id": 13528596,
      "part": {
            "part_num": "4162",
        "name": "Tile 1 x 8 with Groove",
        "part_cat_id": 19,
        "part_url": "https://rebrickable.com/parts/4162/tile-1-x-8-with-groove/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4261701.jpg",
        "external_ids": {
                "BrickLink": [
                  "4162"
          ],
          "BrickOwl": [
            "221729"
          ],
          "Brickset": [
            "40929",
            "4162"
          ],
          "LDraw": [
            "4162"
          ],
          "LEGO": [
            "40929",
            "4162"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "4539083",
      "num_sets": 68
    },
    {
        "id": 13528545,
      "inv_part_id": 13528545,
      "part": {
            "part_num": "27925",
        "name": "Tile 2 x 2 Curved, Macaroni",
        "part_cat_id": 67,
        "part_url": "https://rebrickable.com/parts/27925/tile-2-x-2-curved-macaroni/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6172632.jpg",
        "external_ids": {
                "BrickLink": [
                  "27925"
          ],
          "BrickOwl": [
            "281026"
          ],
          "Brickset": [
            "27925",
            "67124",
            "78560"
          ],
          "LDraw": [
            "27925"
          ],
          "LEGO": [
            "27925",
            "67124",
            "78560"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6172632",
      "num_sets": 26
    },
    {
        "id": 13528569,
      "inv_part_id": 13528569,
      "part": {
            "part_num": "3068b",
        "name": "Tile 2 x 2 with Groove",
        "part_cat_id": 19,
        "part_url": "https://rebrickable.com/parts/3068b/tile-2-x-2-with-groove/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4177046.jpg",
        "external_ids": {
                "BrickLink": [
                  "3068"
          ],
          "BrickOwl": [
            "462122"
          ],
          "Brickset": [
            "1136",
            "3068",
            "63327",
            "78814"
          ],
          "LDraw": [
            "3068b"
          ],
          "LEGO": [
            "1136",
            "3068",
            "63327",
            "78814"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "4539105",
      "num_sets": 119
    },
    {
        "id": 13528577,
      "inv_part_id": 13528577,
      "part": {
            "part_num": "35787",
        "name": "Tile 45° Cut 2 x 2",
        "part_cat_id": 15,
        "part_url": "https://rebrickable.com/parts/35787/tile-45-cut-2-x-2/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6288635.jpg",
        "external_ids": {
                "BrickLink": [
                  "35787"
          ],
          "BrickOwl": [
            "565869"
          ],
          "Brickset": [
            "35787",
            "66142",
            "69537"
          ],
          "LDraw": [
            "35787"
          ],
          "LEGO": [
            "35787",
            "66142",
            "69537"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "6288635",
      "num_sets": 20
    },
    {
        "id": 13528526,
      "inv_part_id": 13528526,
      "part": {
            "part_num": "15535",
        "name": "Tile Round 2 x 2 with Hole",
        "part_cat_id": 15,
        "part_url": "https://rebrickable.com/parts/15535/tile-round-2-x-2-with-hole/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6315199.jpg",
        "external_ids": {
                "BrickLink": [
                  "15535"
          ],
          "BrickOwl": [
            "893466"
          ],
          "Brickset": [
            "15535"
          ],
          "LDraw": [
            "15535"
          ],
          "LEGO": [
            "15535"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6315199",
      "num_sets": 8
    },
    {
        "id": 13528603,
      "inv_part_id": 13528603,
      "part": {
            "part_num": "43723",
        "name": "Wedge Plate 3 x 2 Left",
        "part_cat_id": 49,
        "part_url": "https://rebrickable.com/parts/43723/wedge-plate-3-x-2-left/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4224297.jpg",
        "external_ids": {
                "BrickLink": [
                  "43723"
          ],
          "BrickOwl": [
            "724978"
          ],
          "Brickset": [
            "43723"
          ],
          "LDraw": [
            "43723"
          ],
          "LEGO": [
            "43723"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6267490",
      "num_sets": 19
    },
    {
        "id": 13528602,
      "inv_part_id": 13528602,
      "part": {
            "part_num": "43722",
        "name": "Wedge Plate 3 x 2 Right",
        "part_cat_id": 49,
        "part_url": "https://rebrickable.com/parts/43722/wedge-plate-3-x-2-right/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4224295.jpg",
        "external_ids": {
                "BrickLink": [
                  "43722"
          ],
          "BrickOwl": [
            "97785"
          ],
          "Brickset": [
            "43722"
          ],
          "LDraw": [
            "43722"
          ],
          "LEGO": [
            "43722"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6267492",
      "num_sets": 22
    },
    {
        "id": 13528599,
      "inv_part_id": 13528599,
      "part": {
            "part_num": "41770",
        "name": "Wedge Plate 4 x 2 Left",
        "part_cat_id": 49,
        "part_url": "https://rebrickable.com/parts/41770/wedge-plate-4-x-2-left/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4162587.jpg",
        "external_ids": {
                "BrickLink": [
                  "41770"
          ],
          "BrickOwl": [
            "44432"
          ],
          "Brickset": [
            "41770",
            "63333"
          ],
          "LDraw": [
            "41770"
          ],
          "LEGO": [
            "41770",
            "63333"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6008593",
      "num_sets": 62
    },
    {
        "id": 13528598,
      "inv_part_id": 13528598,
      "part": {
            "part_num": "41769",
        "name": "Wedge Plate 4 x 2 Right",
        "part_cat_id": 49,
        "part_url": "https://rebrickable.com/parts/41769/wedge-plate-4-x-2-right/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4162586.jpg",
        "external_ids": {
                "BrickLink": [
                  "41769"
          ],
          "BrickOwl": [
            "886867"
          ],
          "Brickset": [
            "41769",
            "63330"
          ],
          "LDraw": [
            "41769"
          ],
          "LEGO": [
            "41769",
            "63330"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6008595",
      "num_sets": 62
    },
    {
        "id": 13528613,
      "inv_part_id": 13528613,
      "part": {
            "part_num": "54384",
        "name": "Wedge Plate 6 x 3 Left",
        "part_cat_id": 49,
        "part_url": "https://rebrickable.com/parts/54384/wedge-plate-6-x-3-left/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4539069.jpg",
        "external_ids": {
                "BrickLink": [
                  "54384"
          ],
          "BrickOwl": [
            "682997"
          ],
          "Brickset": [
            "54384"
          ],
          "LDraw": [
            "54384"
          ],
          "LEGO": [
            "54384"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "4539069",
      "num_sets": 35
    },
    {
        "id": 13528611,
      "inv_part_id": 13528611,
      "part": {
            "part_num": "54383",
        "name": "Wedge Plate 6 x 3 Right",
        "part_cat_id": 49,
        "part_url": "https://rebrickable.com/parts/54383/wedge-plate-6-x-3-right/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4539068.jpg",
        "external_ids": {
                "BrickLink": [
                  "54383"
          ],
          "BrickOwl": [
            "718280"
          ],
          "Brickset": [
            "54383"
          ],
          "LDraw": [
            "54383"
          ],
          "LEGO": [
            "54383"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 320,
        "name": "Dark Red",
        "rgb": "720E0F",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      59
                  ],
            "ext_descrs": [
              [
                "Dark Red"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      56
            ],
            "ext_descrs": [
              [
                "Dark Red"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      154
            ],
            "ext_descrs": [
              [
                "Dark red",
                "NEW DARK RED"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "dkred"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      320
            ],
            "ext_descrs": [
              [
                "Dark_Red"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "4539068",
      "num_sets": 35
    },
    {
        "id": 13528636,
      "inv_part_id": 13528636,
      "part": {
            "part_num": "79389",
        "name": "Bracket 1 x 1 - 1 x 2",
        "part_cat_id": 9,
        "part_url": "https://rebrickable.com/parts/79389/bracket-1-x-1-1-x-2/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6362975.jpg",
        "external_ids": {
                "BrickLink": [
                  "79389"
          ],
          "BrickOwl": [
            "773418"
          ],
          "Brickset": [
            "79389"
          ],
          "LDraw": [
            "79389"
          ],
          "LEGO": [
            "79389"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 71,
        "name": "Light Bluish Gray",
        "rgb": "A0A5A9",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      86
                  ],
            "ext_descrs": [
              [
                "Light Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      64
            ],
            "ext_descrs": [
              [
                "Medium Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      194
            ],
            "ext_descrs": [
              [
                "Medium stone grey",
                "MED. ST-GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "mdstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      71
            ],
            "ext_descrs": [
              [
                "Light_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "6362975",
      "num_sets": 73
    },
    {
        "id": 13528649,
      "inv_part_id": 13528649,
      "part": {
            "part_num": "99781",
        "name": "Bracket 1 x 2 - 1 x 2",
        "part_cat_id": 9,
        "part_url": "https://rebrickable.com/parts/99781/bracket-1-x-2-1-x-2/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4654582.jpg",
        "external_ids": {
                "BrickLink": [
                  "99781"
          ],
          "BrickOwl": [
            "151397"
          ],
          "Brickset": [
            "99781"
          ],
          "LDraw": [
            "99781"
          ],
          "LEGO": [
            "99781"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 71,
        "name": "Light Bluish Gray",
        "rgb": "A0A5A9",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      86
                  ],
            "ext_descrs": [
              [
                "Light Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      64
            ],
            "ext_descrs": [
              [
                "Medium Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      194
            ],
            "ext_descrs": [
              [
                "Medium stone grey",
                "MED. ST-GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "mdstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      71
            ],
            "ext_descrs": [
              [
                "Light_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "4654582",
      "num_sets": 507
    },
    {
        "id": 13528523,
      "inv_part_id": 13528523,
      "part": {
            "part_num": "11215",
        "name": "Bracket 5 x 2 x 1 1/3",
        "part_cat_id": 9,
        "part_url": "https://rebrickable.com/parts/11215/bracket-5-x-2-x-1-13/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6028811.jpg",
        "external_ids": {
                "BrickLink": [
                  "11215"
          ],
          "BrickOwl": [
            "600784"
          ],
          "Brickset": [
            "11215"
          ],
          "LDraw": [
            "11215"
          ],
          "LEGO": [
            "11215"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 71,
        "name": "Light Bluish Gray",
        "rgb": "A0A5A9",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      86
                  ],
            "ext_descrs": [
              [
                "Light Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      64
            ],
            "ext_descrs": [
              [
                "Medium Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      194
            ],
            "ext_descrs": [
              [
                "Medium stone grey",
                "MED. ST-GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "mdstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      71
            ],
            "ext_descrs": [
              [
                "Light_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6028811",
      "num_sets": 197
    },
    {
        "id": 13528529,
      "inv_part_id": 13528529,
      "part": {
            "part_num": "17485",
        "name": "Brick Round 2 x 2 with Pin Holes",
        "part_cat_id": 20,
        "part_url": "https://rebrickable.com/parts/17485/brick-round-2-x-2-with-pin-holes/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6078985.jpg",
        "external_ids": {
                "BrickLink": [
                  "17485"
          ],
          "BrickOwl": [
            "399701"
          ],
          "Brickset": [
            "17485",
            "79566"
          ],
          "LDraw": [
            "17485"
          ],
          "LEGO": [
            "17485",
            "79566"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 71,
        "name": "Light Bluish Gray",
        "rgb": "A0A5A9",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      86
                  ],
            "ext_descrs": [
              [
                "Light Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      64
            ],
            "ext_descrs": [
              [
                "Medium Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      194
            ],
            "ext_descrs": [
              [
                "Medium stone grey",
                "MED. ST-GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "mdstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      71
            ],
            "ext_descrs": [
              [
                "Light_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6372076",
      "num_sets": 79
    },
    {
        "id": 13528534,
      "inv_part_id": 13528534,
      "part": {
            "part_num": "22885",
        "name": "Brick Special 1 x 2 x 1 2/3 with 4 Studs on 1 Side",
        "part_cat_id": 5,
        "part_url": "https://rebrickable.com/parts/22885/brick-special-1-x-2-x-1-23-with-4-studs-on-1-side/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6123809.jpg",
        "external_ids": {
                "BrickLink": [
                  "22885"
          ],
          "BrickOwl": [
            "286400"
          ],
          "Brickset": [
            "22885"
          ],
          "LDraw": [
            "22885"
          ],
          "LEGO": [
            "22885"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 71,
        "name": "Light Bluish Gray",
        "rgb": "A0A5A9",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      86
                  ],
            "ext_descrs": [
              [
                "Light Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      64
            ],
            "ext_descrs": [
              [
                "Medium Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      194
            ],
            "ext_descrs": [
              [
                "Medium stone grey",
                "MED. ST-GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "mdstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      71
            ],
            "ext_descrs": [
              [
                "Light_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6123809",
      "num_sets": 487
    },
    {
        "id": 13528558,
      "inv_part_id": 13528558,
      "part": {
            "part_num": "3023",
        "name": "Plate 1 x 2",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3023/plate-1-x-2/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4211398.jpg",
        "external_ids": {
                "BrickLink": [
                  "3023"
          ],
          "BrickOwl": [
            "44980"
          ],
          "Brickset": [
            "28653",
            "3023",
            "6225"
          ],
          "LDraw": [
            "28653",
            "3023",
            "3023b"
          ],
          "LEGO": [
            "28653",
            "3023",
            "6225"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 71,
        "name": "Light Bluish Gray",
        "rgb": "A0A5A9",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      86
                  ],
            "ext_descrs": [
              [
                "Light Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      64
            ],
            "ext_descrs": [
              [
                "Medium Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      194
            ],
            "ext_descrs": [
              [
                "Medium stone grey",
                "MED. ST-GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "mdstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      71
            ],
            "ext_descrs": [
              [
                "Light_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "4211398",
      "num_sets": 1417
    },
    {
        "id": 13528555,
      "inv_part_id": 13528555,
      "part": {
            "part_num": "3022",
        "name": "Plate 2 x 2",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3022/plate-2-x-2/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4211397.jpg",
        "external_ids": {
                "BrickLink": [
                  "3022"
          ],
          "BrickOwl": [
            "566026"
          ],
          "Brickset": [
            "3022",
            "94148"
          ],
          "LDraw": [
            "3022",
            "94148"
          ],
          "LEGO": [
            "3022",
            "94148"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 71,
        "name": "Light Bluish Gray",
        "rgb": "A0A5A9",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      86
                  ],
            "ext_descrs": [
              [
                "Light Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      64
            ],
            "ext_descrs": [
              [
                "Medium Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      194
            ],
            "ext_descrs": [
              [
                "Medium stone grey",
                "MED. ST-GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "mdstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      71
            ],
            "ext_descrs": [
              [
                "Light_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 5,
      "is_spare": false,
      "element_id": "4211397",
      "num_sets": 1093
    },
    {
        "id": 13528553,
      "inv_part_id": 13528553,
      "part": {
            "part_num": "3021",
        "name": "Plate 2 x 3",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3021/plate-2-x-3/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4211396.jpg",
        "external_ids": {
                "BrickLink": [
                  "3021"
          ],
          "BrickOwl": [
            "960521"
          ],
          "Brickset": [
            "3021"
          ],
          "LDraw": [
            "3021"
          ],
          "LEGO": [
            "3021"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 71,
        "name": "Light Bluish Gray",
        "rgb": "A0A5A9",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      86
                  ],
            "ext_descrs": [
              [
                "Light Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      64
            ],
            "ext_descrs": [
              [
                "Medium Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      194
            ],
            "ext_descrs": [
              [
                "Medium stone grey",
                "MED. ST-GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "mdstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      71
            ],
            "ext_descrs": [
              [
                "Light_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "4211396",
      "num_sets": 926
    },
    {
        "id": 13528550,
      "inv_part_id": 13528550,
      "part": {
            "part_num": "3020",
        "name": "Plate 2 x 4",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3020/plate-2-x-4/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4211395.jpg",
        "external_ids": {
                "BrickLink": [
                  "3020"
          ],
          "BrickOwl": [
            "80025"
          ],
          "Brickset": [
            "3020"
          ],
          "LDraw": [
            "3020"
          ],
          "LEGO": [
            "3020"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 71,
        "name": "Light Bluish Gray",
        "rgb": "A0A5A9",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      86
                  ],
            "ext_descrs": [
              [
                "Light Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      64
            ],
            "ext_descrs": [
              [
                "Medium Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      194
            ],
            "ext_descrs": [
              [
                "Medium stone grey",
                "MED. ST-GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "mdstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      71
            ],
            "ext_descrs": [
              [
                "Light_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "4211395",
      "num_sets": 1168
    },
    {
        "id": 13528542,
      "inv_part_id": 13528542,
      "part": {
            "part_num": "26047",
        "name": "Plate Special 1 x 1 Rounded with Handle",
        "part_cat_id": 9,
        "part_url": "https://rebrickable.com/parts/26047/plate-special-1-x-1-rounded-with-handle/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6225246.jpg",
        "external_ids": {
                "BrickLink": [
                  "26047"
          ],
          "BrickOwl": [
            "454977"
          ],
          "Brickset": [
            "26047"
          ],
          "LDraw": [
            "26047"
          ],
          "LEGO": [
            "26047"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 71,
        "name": "Light Bluish Gray",
        "rgb": "A0A5A9",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      86
                  ],
            "ext_descrs": [
              [
                "Light Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      64
            ],
            "ext_descrs": [
              [
                "Medium Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      194
            ],
            "ext_descrs": [
              [
                "Medium stone grey",
                "MED. ST-GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "mdstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      71
            ],
            "ext_descrs": [
              [
                "Light_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6225246",
      "num_sets": 153
    },
    {
        "id": 13528640,
      "inv_part_id": 13528640,
      "part": {
            "part_num": "87580",
        "name": "Plate Special 2 x 2 with Groove and Center Stud (Jumper)",
        "part_cat_id": 9,
        "part_url": "https://rebrickable.com/parts/87580/plate-special-2-x-2-with-groove-and-center-stud-jumper/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4565393.jpg",
        "external_ids": {
                "BrickLink": [
                  "87580"
          ],
          "BrickOwl": [
            "374469"
          ],
          "Brickset": [
            "23893",
            "87580",
            "92569"
          ],
          "LDraw": [
            "87580"
          ],
          "LEGO": [
            "23893",
            "87580",
            "92569"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 71,
        "name": "Light Bluish Gray",
        "rgb": "A0A5A9",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      86
                  ],
            "ext_descrs": [
              [
                "Light Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      64
            ],
            "ext_descrs": [
              [
                "Medium Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      194
            ],
            "ext_descrs": [
              [
                "Medium stone grey",
                "MED. ST-GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "mdstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      71
            ],
            "ext_descrs": [
              [
                "Light_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6126082",
      "num_sets": 438
    },
    {
        "id": 13528635,
      "inv_part_id": 13528635,
      "part": {
            "part_num": "73230",
        "name": "Technic Brick 1 x 1 with Axle Hole",
        "part_cat_id": 8,
        "part_url": "https://rebrickable.com/parts/73230/technic-brick-1-x-1-with-axle-hole/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6336539.jpg",
        "external_ids": {
                "BrickLink": [
                  "73230"
          ],
          "BrickOwl": [
            "636026"
          ],
          "Brickset": [
            "73230"
          ],
          "LDraw": [
            "73230"
          ],
          "LEGO": [
            "73230"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 71,
        "name": "Light Bluish Gray",
        "rgb": "A0A5A9",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      86
                  ],
            "ext_descrs": [
              [
                "Light Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      64
            ],
            "ext_descrs": [
              [
                "Medium Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      194
            ],
            "ext_descrs": [
              [
                "Medium stone grey",
                "MED. ST-GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "mdstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      71
            ],
            "ext_descrs": [
              [
                "Light_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 8,
      "is_spare": false,
      "element_id": "6336539",
      "num_sets": 78
    },
    {
        "id": 13528528,
      "inv_part_id": 13528528,
      "part": {
            "part_num": "15712",
        "name": "Tile Special 1 x 1 with Clip with Rounded Edges",
        "part_cat_id": 15,
        "part_url": "https://rebrickable.com/parts/15712/tile-special-1-x-1-with-clip-with-rounded-edges/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6071229.jpg",
        "external_ids": {
                "BrickLink": [
                  "15712"
          ],
          "BrickOwl": [
            "859237"
          ],
          "Brickset": [
            "15712",
            "44842"
          ],
          "LDraw": [
            "15712"
          ],
          "LEGO": [
            "15712",
            "44842"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 71,
        "name": "Light Bluish Gray",
        "rgb": "A0A5A9",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      86
                  ],
            "ext_descrs": [
              [
                "Light Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      64
            ],
            "ext_descrs": [
              [
                "Medium Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      194
            ],
            "ext_descrs": [
              [
                "Medium stone grey",
                "MED. ST-GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "mdstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      71
            ],
            "ext_descrs": [
              [
                "Light_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6308012",
      "num_sets": 391
    },
    {
        "id": 13528585,
      "inv_part_id": 13528585,
      "part": {
            "part_num": "3679",
        "name": "Turntable 2 x 2 Plate - Top",
        "part_cat_id": 18,
        "part_url": "https://rebrickable.com/parts/3679/turntable-2-x-2-plate-top/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4211439.jpg",
        "external_ids": {
                "BrickLink": [
                  "3679"
          ],
          "BrickOwl": [
            "776865"
          ],
          "Brickset": [
            "3679"
          ],
          "LDraw": [
            "3679"
          ],
          "LEGO": [
            "3679"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 71,
        "name": "Light Bluish Gray",
        "rgb": "A0A5A9",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      86
                  ],
            "ext_descrs": [
              [
                "Light Bluish Gray"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      64
            ],
            "ext_descrs": [
              [
                "Medium Stone Gray"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      194
            ],
            "ext_descrs": [
              [
                "Medium stone grey",
                "MED. ST-GREY"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "mdstone"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      71
            ],
            "ext_descrs": [
              [
                "Light_Bluish_Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "4540203",
      "num_sets": 681
    },
    {
        "id": 13528538,
      "inv_part_id": 13528538,
      "part": {
            "part_num": "2431",
        "name": "Tile 1 x 4 with Groove",
        "part_cat_id": 19,
        "part_url": "https://rebrickable.com/parts/2431/tile-1-x-4-with-groove/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4164021.jpg",
        "external_ids": {
                "BrickLink": [
                  "2431"
          ],
          "BrickOwl": [
            "853045"
          ],
          "Brickset": [
            "100687",
            "2431",
            "35371",
            "75703",
            "91143"
          ],
          "LDraw": [
            "2431"
          ],
          "LEGO": [
            "100687",
            "2431",
            "35371",
            "75703",
            "91143"
          ],
          "Peeron": [
            "2431b"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 27,
        "name": "Lime",
        "rgb": "BBE90B",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      34
                  ],
            "ext_descrs": [
              [
                "Lime"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      70
            ],
            "ext_descrs": [
              [
                "Lime"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      119
            ],
            "ext_descrs": [
              [
                "Br. yellowish green",
                "BR.YEL-GREEN"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "lime"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      27
            ],
            "ext_descrs": [
              [
                "Lime"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "4164021",
      "num_sets": 150
    },
    {
        "id": 13528628,
      "inv_part_id": 13528628,
      "part": {
            "part_num": "65429",
        "name": "Wedge Plate 2 x 4 27° Left",
        "part_cat_id": 49,
        "part_url": "https://rebrickable.com/parts/65429/wedge-plate-2-x-4-27-left/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6341762.jpg",
        "external_ids": {
                "BrickLink": [
                  "65429"
          ],
          "BrickOwl": [
            "619927"
          ],
          "Brickset": [
            "100868",
            "65429"
          ],
          "LDraw": [
            "65429"
          ],
          "LEGO": [
            "100868",
            "65429"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 27,
        "name": "Lime",
        "rgb": "BBE90B",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      34
                  ],
            "ext_descrs": [
              [
                "Lime"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      70
            ],
            "ext_descrs": [
              [
                "Lime"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      119
            ],
            "ext_descrs": [
              [
                "Br. yellowish green",
                "BR.YEL-GREEN"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "lime"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      27
            ],
            "ext_descrs": [
              [
                "Lime"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6341762",
      "num_sets": 3
    },
    {
        "id": 13528626,
      "inv_part_id": 13528626,
      "part": {
            "part_num": "65426",
        "name": "Wedge Plate 2 x 4 27° Right",
        "part_cat_id": 49,
        "part_url": "https://rebrickable.com/parts/65426/wedge-plate-2-x-4-27-right/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6341764.jpg",
        "external_ids": {
                "BrickLink": [
                  "65426"
          ],
          "BrickOwl": [
            "793252"
          ],
          "Brickset": [
            "100867",
            "65426"
          ],
          "LDraw": [
            "65426"
          ],
          "LEGO": [
            "100867",
            "65426"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 27,
        "name": "Lime",
        "rgb": "BBE90B",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      34
                  ],
            "ext_descrs": [
              [
                "Lime"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      70
            ],
            "ext_descrs": [
              [
                "Lime"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      119
            ],
            "ext_descrs": [
              [
                "Br. yellowish green",
                "BR.YEL-GREEN"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "lime"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      27
            ],
            "ext_descrs": [
              [
                "Lime"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6341764",
      "num_sets": 3
    },
    {
        "id": 13972022,
      "inv_part_id": 13972022,
      "part": {
            "part_num": "64567",
        "name": "Weapon Lightsaber Hilt with Bottom Ring",
        "part_cat_id": 27,
        "part_url": "https://rebrickable.com/parts/64567/weapon-lightsaber-hilt-with-bottom-ring/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4548731.jpg",
        "external_ids": {
                "BrickLink": [
                  "64567"
          ],
          "BrickOwl": [
            "459306"
          ],
          "Brickset": [
            "15556",
            "64567",
            "86132"
          ],
          "LDraw": [
            "577b",
            "64567a"
          ],
          "LEGO": [
            "15556",
            "64567",
            "86132"
          ],
          "Peeron": [
            "577"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 80,
        "name": "Metallic Silver",
        "rgb": "A5A9B4",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      67
                  ],
            "ext_descrs": [
              [
                "Metallic Silver"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      126
            ],
            "ext_descrs": [
              [
                "Metallic Silver"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "metallicsilver"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      80
            ],
            "ext_descrs": [
              [
                "Metallic_Silver"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      336,
              298
            ],
            "ext_descrs": [
              [
                "SILVER INK"
              ],
              [
                "C.SILVER, DR. L"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": true,
      "element_id": "6051389",
      "num_sets": 210
    },
    {
        "id": 13528625,
      "inv_part_id": 13528625,
      "part": {
            "part_num": "64567",
        "name": "Weapon Lightsaber Hilt with Bottom Ring",
        "part_cat_id": 27,
        "part_url": "https://rebrickable.com/parts/64567/weapon-lightsaber-hilt-with-bottom-ring/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4548731.jpg",
        "external_ids": {
                "BrickLink": [
                  "64567"
          ],
          "BrickOwl": [
            "459306"
          ],
          "Brickset": [
            "15556",
            "64567",
            "86132"
          ],
          "LDraw": [
            "577b",
            "64567a"
          ],
          "LEGO": [
            "15556",
            "64567",
            "86132"
          ],
          "Peeron": [
            "577"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 80,
        "name": "Metallic Silver",
        "rgb": "A5A9B4",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      67
                  ],
            "ext_descrs": [
              [
                "Metallic Silver"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      126
            ],
            "ext_descrs": [
              [
                "Metallic Silver"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "metallicsilver"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      80
            ],
            "ext_descrs": [
              [
                "Metallic_Silver"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      336,
              298
            ],
            "ext_descrs": [
              [
                "SILVER INK"
              ],
              [
                "C.SILVER, DR. L"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6051389",
      "num_sets": 210
    },
    {
        "id": 13544062,
      "inv_part_id": 13544062,
      "part": {
            "part_num": "10100764",
        "name": "Sticker Sheet for Set 75333-1",
        "part_cat_id": 58,
        "part_url": "https://rebrickable.com/parts/10100764/sticker-sheet-for-set-75333-1/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/photos/15/PART-18749-15-66604add-e2fe-4654-abaf-93d6eef61725.jpg",
        "external_ids": {
                "BrickLink": [
                  "75333stk01"
          ],
          "BrickOwl": [
            "1088917"
          ],
          "LEGO": [
            "100764"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 9999,
        "name": "[No Color/Any Color]",
        "rgb": "05131D",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      0
                  ],
            "ext_descrs": [
              [
                "(Not Applicable)"
                    ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6410045",
      "num_sets": 1
    },
    {
        "id": 13528633,
      "inv_part_id": 13528633,
      "part": {
            "part_num": "69754",
        "name": "Launcher, Plate Special 1 x 2 with Mini Blaster Square",
        "part_cat_id": 68,
        "part_url": "https://rebrickable.com/parts/69754/launcher-plate-special-1-x-2-with-mini-blaster-square/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6345952.jpg",
        "external_ids": {
                "BrickLink": [
                  "69754"
          ],
          "BrickOwl": [
            "472925"
          ],
          "Brickset": [
            "69754"
          ],
          "LDraw": [
            "69754"
          ],
          "LEGO": [
            "69754"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 1103,
        "name": "Pearl Titanium",
        "rgb": "3E3C39",
        "is_trans": false,
        "external_ids": {
                "LEGO": {
                    "ext_ids": [
                      316
                  ],
            "ext_descrs": [
              [
                "Titanium Metallic",
                "TITAN. METAL."
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      119
            ],
            "ext_descrs": [
              [
                "Pearl Dark Gray"
              ]
            ]
          },
          "BrickLink": {
                    "ext_ids": [
                      77
            ],
            "ext_descrs": [
              [
                "Pearl Dark Gray"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6345952",
      "num_sets": 30
    },
    {
        "id": 13528616,
      "inv_part_id": 13528616,
      "part": {
            "part_num": "59276",
        "name": "Hood Long, Angular",
        "part_cat_id": 65,
        "part_url": "https://rebrickable.com/parts/59276/hood-long-angular/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6275486.jpg",
        "external_ids": {
                "BrickLink": [
                  "59276"
          ],
          "BrickOwl": [
            "886638"
          ],
          "Brickset": [
            "59276"
          ],
          "LDraw": [
            "59276"
          ],
          "LEGO": [
            "59276"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 70,
        "name": "Reddish Brown",
        "rgb": "582A12",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      88
                  ],
            "ext_descrs": [
              [
                "Reddish Brown"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      82
            ],
            "ext_descrs": [
              [
                "Reddish Brown"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      192
            ],
            "ext_descrs": [
              [
                "Reddish Brown",
                "RED. BROWN"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "redbrown"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      70
            ],
            "ext_descrs": [
              [
                "Reddish_Brown"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6275486",
      "num_sets": 2
    },
    {
        "id": 13528622,
      "inv_part_id": 13528622,
      "part": {
            "part_num": "6141",
        "name": "Plate Round 1 x 1 with Solid Stud",
        "part_cat_id": 21,
        "part_url": "https://rebrickable.com/parts/6141/plate-round-1-x-1-with-solid-stud/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6057034.jpg",
        "external_ids": {
                "BrickLink": [
                  "4073"
          ],
          "BrickOwl": [
            "961948"
          ],
          "Brickset": [
            "15570",
            "30057",
            "34823",
            "39799",
            "44325",
            "6141"
          ],
          "LDraw": [
            "4073",
            "6141"
          ],
          "LEGO": [
            "15570",
            "30057",
            "34823",
            "39799",
            "44325",
            "51809",
            "6141"
          ],
          "Peeron": [
            "4073"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 35,
        "name": "Trans-Bright Green",
        "rgb": "D9E4A7",
        "is_trans": true,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      108
                  ],
            "ext_descrs": [
              [
                "Trans-Bright Green"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      96
            ],
            "ext_descrs": [
              [
                "Transparent Bright Green"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      311
            ],
            "ext_descrs": [
              [
                "Transparent Bright Green",
                "TR. BR. GREEN"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "trbtgreen"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      35
            ],
            "ext_descrs": [
              [
                "Trans_Bright_Green"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "6240206",
      "num_sets": 141
    },
    {
        "id": 13528641,
      "inv_part_id": 13528641,
      "part": {
            "part_num": "87752",
        "name": "Windscreen 6 x 4 x 2 1/3 Bubble Canopy with Handle",
        "part_cat_id": 47,
        "part_url": "https://rebrickable.com/parts/87752/windscreen-6-x-4-x-2-13-bubble-canopy-with-handle/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4653512.jpg",
        "external_ids": {
                "BrickLink": [
                  "87752"
          ],
          "BrickOwl": [
            "526416"
          ],
          "Brickset": [
            "35345",
            "87752"
          ],
          "LDraw": [
            "87752"
          ],
          "LEGO": [
            "35345",
            "87752"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 47,
        "name": "Trans-Clear",
        "rgb": "FCFCFC",
        "is_trans": true,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      12
                  ],
            "ext_descrs": [
              [
                "Trans-Clear"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      97
            ],
            "ext_descrs": [
              [
                "Transparent"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      40
            ],
            "ext_descrs": [
              [
                "Transparent",
                "TR."
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "clear"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      47
            ],
            "ext_descrs": [
              [
                "Trans_Clear"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6507954",
      "num_sets": 10
    },
    {
        "id": 13528568,
      "inv_part_id": 13528568,
      "part": {
            "part_num": "30374",
        "name": "Bar 4L (Lightsaber Blade / Wand)",
        "part_cat_id": 32,
        "part_url": "https://rebrickable.com/parts/30374/bar-4l-lightsaber-blade-wand/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4124073.jpg",
        "external_ids": {
                "BrickLink": [
                  "30374"
          ],
          "BrickOwl": [
            "324854"
          ],
          "Brickset": [
            "21462",
            "28697",
            "30374"
          ],
          "LDraw": [
            "30374"
          ],
          "LEGO": [
            "21462",
            "28697",
            "30374"
          ],
          "Peeron": [
            "578"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 41,
        "name": "Trans-Light Blue",
        "rgb": "AEEFEC",
        "is_trans": true,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      15
                  ],
            "ext_descrs": [
              [
                "Trans-Light Blue"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      101
            ],
            "ext_descrs": [
              [
                "Transparent Light Blue"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "trltblue"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      43
            ],
            "ext_descrs": [
              [
                "Trans_Medium_Blue"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      42
            ],
            "ext_descrs": [
              [
                "Tr. Lg blue",
                "TR.L.BLUE"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "6507882",
      "num_sets": 278
    },
    {
        "id": 13528543,
      "inv_part_id": 13528543,
      "part": {
            "part_num": "2654",
        "name": "Plate Round 2 x 2 with Rounded Bottom [Boat Stud]",
        "part_cat_id": 21,
        "part_url": "https://rebrickable.com/parts/2654/plate-round-2-x-2-with-rounded-bottom-boat-stud/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4214760.jpg",
        "external_ids": {
                "BrickLink": [
                  "2654"
          ],
          "BrickOwl": [
            "243161"
          ],
          "Brickset": [
            "2654",
            "28558",
            "54196",
            "93791"
          ],
          "LDraw": [
            "2654a"
          ],
          "LEGO": [
            "2654",
            "28558",
            "54196",
            "93791"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 46,
        "name": "Trans-Yellow",
        "rgb": "F5CD2F",
        "is_trans": true,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      19
                  ],
            "ext_descrs": [
              [
                "Trans-Yellow"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      109
            ],
            "ext_descrs": [
              [
                "Transparent Yellow"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      44
            ],
            "ext_descrs": [
              [
                "Tr. Yellow",
                "TR.YEL"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null,
              null
            ],
            "ext_descrs": [
              [
                "tryellow"
              ],
              [
                "trltyellow"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      46
            ],
            "ext_descrs": [
              [
                "Trans_Yellow"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6171728",
      "num_sets": 120
    },
    {
        "id": 13528648,
      "inv_part_id": 13528648,
      "part": {
            "part_num": "99207",
        "name": "Bracket 1 x 2 - 2 x 2 Inverted",
        "part_cat_id": 9,
        "part_url": "https://rebrickable.com/parts/99207/bracket-1-x-2-2-x-2-inverted/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6097637.jpg",
        "external_ids": {
                "BrickLink": [
                  "99207"
          ],
          "BrickOwl": [
            "723322"
          ],
          "Brickset": [
            "99207"
          ],
          "LDraw": [
            "99207"
          ],
          "LEGO": [
            "99207"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 15,
        "name": "White",
        "rgb": "FFFFFF",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      1
                  ],
            "ext_descrs": [
              [
                "White"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      92
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      1
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "white"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      15
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "6097637",
      "num_sets": 187
    },
    {
        "id": 13528548,
      "inv_part_id": 13528548,
      "part": {
            "part_num": "3004",
        "name": "Brick 1 x 2",
        "part_cat_id": 11,
        "part_url": "https://rebrickable.com/parts/3004/brick-1-x-2/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/300401.jpg",
        "external_ids": {
                "BrickLink": [
                  "3004"
          ],
          "BrickOwl": [
            "442413"
          ],
          "Brickset": [
            "3004",
            "93792"
          ],
          "LDraw": [
            "3004",
            "93792"
          ],
          "LEGO": [
            "3004",
            "93792"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 15,
        "name": "White",
        "rgb": "FFFFFF",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      1
                  ],
            "ext_descrs": [
              [
                "White"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      92
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      1
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "white"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      15
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": false,
      "element_id": "4613964",
      "num_sets": 1840
    },
    {
        "id": 13528530,
      "inv_part_id": 13528530,
      "part": {
            "part_num": "17485",
        "name": "Brick Round 2 x 2 with Pin Holes",
        "part_cat_id": 20,
        "part_url": "https://rebrickable.com/parts/17485/brick-round-2-x-2-with-pin-holes/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/6218899.jpg",
        "external_ids": {
                "BrickLink": [
                  "17485"
          ],
          "BrickOwl": [
            "399701"
          ],
          "Brickset": [
            "17485",
            "79566"
          ],
          "LDraw": [
            "17485"
          ],
          "LEGO": [
            "17485",
            "79566"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 15,
        "name": "White",
        "rgb": "FFFFFF",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      1
                  ],
            "ext_descrs": [
              [
                "White"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      92
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      1
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "white"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      15
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "6218899",
      "num_sets": 36
    },
    {
        "id": 13972015,
      "inv_part_id": 13972015,
      "part": {
            "part_num": "3024",
        "name": "Plate 1 x 1",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3024/plate-1-x-1/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/302401.jpg",
        "external_ids": {
                "BrickLink": [
                  "3024"
          ],
          "BrickOwl": [
            "322944"
          ],
          "Brickset": [
            "28554",
            "30008",
            "3024",
            "63326"
          ],
          "LDraw": [
            "3024"
          ],
          "LEGO": [
            "28554",
            "30008",
            "3024",
            "63326"
          ],
          "Peeron": [
            "30008"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 15,
        "name": "White",
        "rgb": "FFFFFF",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      1
                  ],
            "ext_descrs": [
              [
                "White"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      92
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      1
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "white"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      15
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 1,
      "is_spare": true,
      "element_id": "302401",
      "num_sets": 1203
    },
    {
        "id": 13528562,
      "inv_part_id": 13528562,
      "part": {
            "part_num": "3024",
        "name": "Plate 1 x 1",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3024/plate-1-x-1/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/302401.jpg",
        "external_ids": {
                "BrickLink": [
                  "3024"
          ],
          "BrickOwl": [
            "322944"
          ],
          "Brickset": [
            "28554",
            "30008",
            "3024",
            "63326"
          ],
          "LDraw": [
            "3024"
          ],
          "LEGO": [
            "28554",
            "30008",
            "3024",
            "63326"
          ],
          "Peeron": [
            "30008"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 15,
        "name": "White",
        "rgb": "FFFFFF",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      1
                  ],
            "ext_descrs": [
              [
                "White"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      92
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      1
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "white"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      15
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "302401",
      "num_sets": 1203
    },
    {
        "id": 13528617,
      "inv_part_id": 13528617,
      "part": {
            "part_num": "60479",
        "name": "Plate 1 x 12",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/60479/plate-1-x-12/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/4514842.jpg",
        "external_ids": {
                "BrickLink": [
                  "60479"
          ],
          "BrickOwl": [
            "43273"
          ],
          "Brickset": [
            "60479"
          ],
          "LDraw": [
            "60479"
          ],
          "LEGO": [
            "60479"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 15,
        "name": "White",
        "rgb": "FFFFFF",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      1
                  ],
            "ext_descrs": [
              [
                "White"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      92
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      1
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "white"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      15
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "4514842",
      "num_sets": 179
    },
    {
        "id": 13528559,
      "inv_part_id": 13528559,
      "part": {
            "part_num": "3023",
        "name": "Plate 1 x 2",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3023/plate-1-x-2/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/302301.jpg",
        "external_ids": {
                "BrickLink": [
                  "3023"
          ],
          "BrickOwl": [
            "44980"
          ],
          "Brickset": [
            "28653",
            "3023",
            "6225"
          ],
          "LDraw": [
            "28653",
            "3023",
            "3023b"
          ],
          "LEGO": [
            "28653",
            "3023",
            "6225"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 15,
        "name": "White",
        "rgb": "FFFFFF",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      1
                  ],
            "ext_descrs": [
              [
                "White"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      92
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      1
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "white"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      15
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 8,
      "is_spare": false,
      "element_id": "302301",
      "num_sets": 2143
    },
    {
        "id": 13528581,
      "inv_part_id": 13528581,
      "part": {
            "part_num": "3623",
        "name": "Plate 1 x 3",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3623/plate-1-x-3/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/362301.jpg",
        "external_ids": {
                "BrickLink": [
                  "3623"
          ],
          "BrickOwl": [
            "212990"
          ],
          "Brickset": [
            "3623"
          ],
          "LDraw": [
            "3623"
          ],
          "LEGO": [
            "3623"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 15,
        "name": "White",
        "rgb": "FFFFFF",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      1
                  ],
            "ext_descrs": [
              [
                "White"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      92
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      1
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "white"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      15
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "362301",
      "num_sets": 880
    },
    {
        "id": 13528588,
      "inv_part_id": 13528588,
      "part": {
            "part_num": "3710",
        "name": "Plate 1 x 4",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3710/plate-1-x-4/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/371001.jpg",
        "external_ids": {
                "BrickLink": [
                  "3710"
          ],
          "BrickOwl": [
            "515555"
          ],
          "Brickset": [
            "3710"
          ],
          "LDraw": [
            "3710"
          ],
          "LEGO": [
            "3710"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 15,
        "name": "White",
        "rgb": "FFFFFF",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      1
                  ],
            "ext_descrs": [
              [
                "White"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      92
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      1
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "white"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      15
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 5,
      "is_spare": false,
      "element_id": "371051",
      "num_sets": 1545
    },
    {
        "id": 13528584,
      "inv_part_id": 13528584,
      "part": {
            "part_num": "3666",
        "name": "Plate 1 x 6",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3666/plate-1-x-6/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/366601.jpg",
        "external_ids": {
                "BrickLink": [
                  "3666"
          ],
          "BrickOwl": [
            "804561"
          ],
          "Brickset": [
            "3666"
          ],
          "LDraw": [
            "3666"
          ],
          "LEGO": [
            "3666"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 15,
        "name": "White",
        "rgb": "FFFFFF",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      1
                  ],
            "ext_descrs": [
              [
                "White"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      92
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      1
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "white"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      15
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "366601",
      "num_sets": 957
    },
    {
        "id": 13528592,
      "inv_part_id": 13528592,
      "part": {
            "part_num": "3832",
        "name": "Plate 2 x 10",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3832/plate-2-x-10/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/383201.jpg",
        "external_ids": {
                "BrickLink": [
                  "3832"
          ],
          "BrickOwl": [
            "639151"
          ],
          "Brickset": [
            "3832"
          ],
          "LDraw": [
            "3832"
          ],
          "LEGO": [
            "3832"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 15,
        "name": "White",
        "rgb": "FFFFFF",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      1
                  ],
            "ext_descrs": [
              [
                "White"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      92
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      1
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "white"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      15
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 4,
      "is_spare": false,
      "element_id": "383201",
      "num_sets": 304
    },
    {
        "id": 13528556,
      "inv_part_id": 13528556,
      "part": {
            "part_num": "3022",
        "name": "Plate 2 x 2",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/3022/plate-2-x-2/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/302201.jpg",
        "external_ids": {
                "BrickLink": [
                  "3022"
          ],
          "BrickOwl": [
            "566026"
          ],
          "Brickset": [
            "3022",
            "94148"
          ],
          "LDraw": [
            "3022",
            "94148"
          ],
          "LEGO": [
            "3022",
            "94148"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 15,
        "name": "White",
        "rgb": "FFFFFF",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      1
                  ],
            "ext_descrs": [
              [
                "White"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      92
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      1
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "white"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      15
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 3,
      "is_spare": false,
      "element_id": "4613976",
      "num_sets": 1442
    },
    {
        "id": 13528536,
      "inv_part_id": 13528536,
      "part": {
            "part_num": "2420",
        "name": "Plate 2 x 2 Corner",
        "part_cat_id": 14,
        "part_url": "https://rebrickable.com/parts/2420/plate-2-x-2-corner/",
        "part_img_url": "https://cdn.rebrickable.com/media/parts/elements/242001.jpg",
        "external_ids": {
                "BrickLink": [
                  "2420"
          ],
          "BrickOwl": [
            "45054"
          ],
          "Brickset": [
            "2420",
            "63325"
          ],
          "LDraw": [
            "2420",
            "63325"
          ],
          "LEGO": [
            "2420",
            "63325"
          ]
        },
        "print_of": null
      },
      "color": {
            "id": 15,
        "name": "White",
        "rgb": "FFFFFF",
        "is_trans": false,
        "external_ids": {
                "BrickLink": {
                    "ext_ids": [
                      1
                  ],
            "ext_descrs": [
              [
                "White"
                    ]
            ]
          },
          "BrickOwl": {
                    "ext_ids": [
                      92
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "LEGO": {
                    "ext_ids": [
                      1
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          },
          "Peeron": {
                    "ext_ids": [
                      null
            ],
            "ext_descrs": [
              [
                "white"
              ]
            ]
          },
          "LDraw": {
                    "ext_ids": [
                      15
            ],
            "ext_descrs": [
              [
                "White"
              ]
            ]
          }
            }
        },
      "set_num": "75333-1",
      "quantity": 2,
      "is_spare": false,
      "element_id": "242051",
      "num_sets": 589
    }
  ]
} */