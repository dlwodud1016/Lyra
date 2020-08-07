using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Lyra.Domain.Entities.TMDB
{
    public class MovieInfo
    {
        [JsonPropertyName("popularity")]
        public float Popularity { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("video")]
        public bool Video { get; set; }

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }

        [JsonPropertyName("vote_average")]
        public float VoteAverage { get; set; }

        [JsonPropertyName("title")]
        public String Title { get; set; }

        [JsonPropertyName("release_date")]
        public String ReleaseDate { get; set; }

        [JsonPropertyName("original_language")]
        public String OriginalLanguage { get; set; }

        [JsonPropertyName("original_title")]
        public String OriginalTitle { get; set; }

        [JsonPropertyName("genre_ids")]
        public List<int> GenreIds { get; set; }

        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("overview")]
        public String Overview { get; set; }
    }
}
