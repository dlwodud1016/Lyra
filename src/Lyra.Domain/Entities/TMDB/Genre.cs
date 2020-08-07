using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lyra.Domain.Entities.TMDB
{
    public class Genre
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public String Name { get; set; }
    }
}
