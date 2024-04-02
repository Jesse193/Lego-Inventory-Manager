﻿using System.Text.Json.Serialization;

namespace LegoInventoryManager.Models
{
    public class RootObject
    {
        [JsonPropertyName("results")]
        public List<Result> result { get; set; }
        public string PartNumber {get; set;}
    }

    public class Result
    {
        [JsonPropertyName("color_name")]
        public string Color { get; set; }

        [JsonPropertyName("part_img_url")]
        public string Image { get; set; }

        [JsonPropertyName("color_id")]
        public int ColorId { get; set; }

        [JsonPropertyName("elements")]
        public List<string> ElementList { get; set; }
    }
}
