﻿using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace AlloCine
{
    [DataContract(Name = "ratingStats")]
    public class RatingStats
    {
        [JsonPropertyName("note")]
        public string Note { get; set; }

        [JsonPropertyName("$")]
        public string Value { get; set; }
    }
}
