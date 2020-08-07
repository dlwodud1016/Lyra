using System;
using System.Text.Json.Serialization;

namespace Lyra.Domain.Entities.TMDB
{
    public class PeopleCast : MovieInfo
    {
        [JsonPropertyName("character")]
        public String Character { get; set; }

        [JsonPropertyName("credit_id")]
        public String CreditId { get; set; }        
    }
}
