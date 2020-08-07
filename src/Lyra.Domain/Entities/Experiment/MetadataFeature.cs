using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Domain.Entities.Experiment
{
    public class MetadataFeature
    {
        // 영화 제작비 금액
        public double Budget { get; set; }

        // 영화 상영기간
        public int Duration { get; set; }

        // 영화 제작에 참여한 제작자 수
        public int TotalCompanies { get; set; }

        // 영화 개봉일
        public int ReleaseDateDay { get; set; }

        // 영화 개봉월
        public int ReleaseDateMonth { get; set; }

        // 영화 개봉년도
        public int ReleaseDateTear { get; set; }

        // 영화 지원하는 언어 수
        public int TotalSpokenLanguage { get; set; }

        // 상영된 국가 수
        public int TotalProductionCountries { get; set; }
    }
}
