using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lyra.Domain.Entities.TMDB
{
    public class ProductionCountry
    {
        [JsonPropertyName("iso_3166_1")]
        public String Iso_3166_1 { get; set; }

        [JsonPropertyName("name")]
        public String Name { get; set; }
    }
}
