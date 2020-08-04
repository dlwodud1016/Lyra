using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lyra.MovieCrawler.Domain.Entities.TMDB
{
    public class TheMoviedbMovieCreditResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        public List<TheMoviedbMovieCreditCast> TheMoviedbMovieCreditCasts { get; set; }

        public List<TheMoviedbMovieCreditCrew> TheMoviedbMovieCreditCrews { get; set; }
    }
}
