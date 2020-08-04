using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lyra.MovieCrawler.Domain.Entities.TMDB
{
    public class TheMoviedbMovieCreditCast : TheMoviedbPeopleCast
    {

        [JsonPropertyName("cast_id")]
        public String CastId { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("name")]
        public String Name { get; set; }

        [JsonPropertyName("order")]
        public int Order { get; set; }
    }
}
