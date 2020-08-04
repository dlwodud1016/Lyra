using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lyra.MovieCrawler.Domain.Entities.TMDB
{
    public class TheMoviedbPeopleCast : TheMoviedbMovieInfo
    {
        [JsonPropertyName("character")]
        public String Character { get; set; }

        [JsonPropertyName("credit_id")]
        public String CreditId { get; set; }        
    }
}
