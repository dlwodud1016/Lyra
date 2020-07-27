using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.MovieCrawler.Parameters
{
    public class KobisParameter
    {
        // 인증키
        public static String Key = "key";

        // 조회 날짜
        public static String TargetDate = "targetDt";

        // 영화/상업영화 조회
        // “Y” : 다양성 영화 “N” : 상업영화 (default : 전체)
        public static String MultiMovieYn = "multiMovieYn";

        // 외국 한국 영화 여부
        // “K: : 한국영화 “F” : 외국영화 (default : 전체)
        public static String RepNationCd = "repNationCd";
        

    }
}
