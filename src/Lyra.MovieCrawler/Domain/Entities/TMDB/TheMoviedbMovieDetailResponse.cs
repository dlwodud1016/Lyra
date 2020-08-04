using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lyra.MovieCrawler.Domain.Entities.TMDB
{
    public class TheMoviedbMovieDetailResponse
    {
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("belongs_to_collection")]
        public String BelongsToCollection { get; set; }

        [JsonPropertyName("budget")]
        public long Budget { get; set; }

        [JsonPropertyName("genres")]
        public List<TheMoviedbGenre> Genres { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("imdb_id")]
        public String ImdbId { get; set; }

        [JsonPropertyName("original_language")]
        public String OriginalLanguage { get; set; }

        [JsonPropertyName("original_title")]
        public String OriginalTitle { get; set; }

        [JsonPropertyName("overview")]
        public String Overview { get; set; }

        [JsonPropertyName("popularity")]
        public double Popularity { get; set; }

        [JsonPropertyName("production_companies")]
        public List<TheMoviedbProductionCompany> ProductionCompanies { get; set; }

        [JsonPropertyName("production_countries")]
        public List<TheMoviedbProductionCountry> ProductionCountries { get; set; }

        [JsonPropertyName("release_date")]
        public String ReleaseDate { get; set; }

        [JsonPropertyName("revenue")]
        public int Revenue { get; set; }

        [JsonPropertyName("runtime")]
        public int Runtime { get; set; }

        [JsonPropertyName("spoken_languages")]
        public List<TheMoviedbSpokenLanguage> SpokenLanguages { get; set; }

        [JsonPropertyName("status")]
        public String Status { get; set; }

        [JsonPropertyName("tagline")]
        public String Tagline { get; set; }

        [JsonPropertyName("title")]
        public String Title { get; set; }

        [JsonPropertyName("video")]
        public bool Video { get; set; }

        [JsonPropertyName("vote_average")]
        public double VoteAverage { get; set; }

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }

        
    }
}
