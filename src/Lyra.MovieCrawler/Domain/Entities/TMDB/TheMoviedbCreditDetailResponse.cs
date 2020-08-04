using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lyra.MovieCrawler.Domain.Entities.TMDB
{
    public class TheMoviedbCreditDetailPerson
    {
        [JsonPropertyName("adult")]
        public bool adult { get; set; }

        [JsonPropertyName("gender")]
        public int Gender { get; set; }

        [JsonPropertyName("name")]
        public String Name { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("known_for_department")]
        public String KnownForDepartment { get; set; }

        [JsonPropertyName("popularity")]
        public float Popularity { get; set; }
    }

    public class TheMoviedbCreditDetailResponse
    {
        [JsonPropertyName("credit_type")]
        public int CreditType { get; set; }

        [JsonPropertyName("department")]
        public String Department { get; set; }

        [JsonPropertyName("job")]
        public String Job { get; set; }

        [JsonPropertyName("media_type")]
        public String MediaType { get; set; }

        [JsonPropertyName("id")]
        public String Id { get; set; }

        [JsonPropertyName("media")]
        public TheMoviedbMovieInfo Media { get; set; }

        [JsonPropertyName("person")]
        public TheMoviedbCreditDetailPerson Person { get; set; }
    }
}
