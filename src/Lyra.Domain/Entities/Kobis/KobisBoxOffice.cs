using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Lyra.Domain.Entities.Kobis
{
    public class KobisBoxOffice
    {
        [JsonPropertyName("rnum")]
        public String RowNumber { get; set; }

        [JsonPropertyName("rank")]
        public String Rank { get; set; }

        [JsonPropertyName("rankInten")]
        public String RankInten { get; set; }

        [JsonPropertyName("rankOldAndNew")]
        public String RankOldAndNew { get; set; }

        [JsonPropertyName("movieCd")]
        public String MovieCd { get; set; }

        [JsonPropertyName("movieNm")]
        public String MovieNm { get; set; }

        [JsonPropertyName("openDt")]
        public String OpenDt { get; set; }

        [JsonPropertyName("salesAmt")]
        public String SalesAmt { get; set; }

        [JsonPropertyName("salesShare")]
        public String SalesShare { get; set; }

        [JsonPropertyName("salesInten")]
        public String SalesInten { get; set; }

        [JsonPropertyName("salesChange")]
        public String SalesChange { get; set; }

        [JsonPropertyName("salesAcc")]
        public String SalesAcc { get; set; }

        [JsonPropertyName("audiCnt")]
        public String AudiCnt { get; set; }

        [JsonPropertyName("audiInten")]
        public String AudiInten { get; set; }

        [JsonPropertyName("audiChange")]
        public String AudiChange { get; set; }

        [JsonPropertyName("audiAcc")]
        public String AudiAcc { get; set; }

        [JsonPropertyName("scrnCnt")]
        public String ScrnCnt { get; set; }

        [JsonPropertyName("showCnt")]
        public String ShowCnt { get; set; }
    }
}
