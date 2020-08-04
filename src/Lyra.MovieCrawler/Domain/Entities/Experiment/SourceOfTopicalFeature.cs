using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.MovieCrawler.Domain.Entities.Experiment
{
    public class SourceOfTopicalFeature
    {
        // 영화 제목
        public String MovieTitle { get; set; }

        // 영화 줄거리 키워드
        public List<String> PlotKeywords { get; set; }

        // 영화 줄거리 요약
        public String Overview { get; set; }

        // 영화 태크
        public List<String> Tagline { get; set; }
    }
}
