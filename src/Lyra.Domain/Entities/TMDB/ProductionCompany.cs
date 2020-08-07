using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lyra.Domain.Entities.TMDB
{
    public class ProductionCompany
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public String Name { get; set; }

        [JsonPropertyName("origin_country")]
        public String OriginCountry { get; set; }
    }
}
