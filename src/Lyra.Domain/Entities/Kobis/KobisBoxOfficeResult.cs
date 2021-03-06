﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lyra.Domain.Entities.Kobis
{
    public class KobisBoxOfficeResult
    {
        [JsonPropertyName("boxofficeType")]
        public String BoxofficeType { get; set; }

        [JsonPropertyName("showRange")]
        public String ShowRange { get; set; }

        [JsonPropertyName("dailyBoxOfficeList")]
        public List<KobisBoxOffice> DailyBoxOfficeList { get; set; }
    }
}
