using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lyra.MovieCrawler.Domain.Entities.TMDB
{
    public class PeopleCrew : MovieInfo
    {
        [JsonPropertyName("department")]
        public String Department { get; set; }

        [JsonPropertyName("job")]
        public String Job { get; set; }

        [JsonPropertyName("credit_id")]
        public String CreditId { get; set; }

    }
}
