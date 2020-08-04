using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lyra.MovieCrawler.Domain.Entities.Kobis
{
    public class KobisBoxOfficeResponse
    {
        [JsonPropertyName("boxOfficeResult")]
        public KobisBoxOfficeResult BoxOfficeResult { get; set; }
    }
}
