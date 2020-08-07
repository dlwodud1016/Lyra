using Lyra.Domain.Entities.TMDB;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Lyra.MovieCrawler.Features.TMDB
{
    public class SearchResponse
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("results")]
        public List<MovieInfo> Results { get; set; }
    }
}
