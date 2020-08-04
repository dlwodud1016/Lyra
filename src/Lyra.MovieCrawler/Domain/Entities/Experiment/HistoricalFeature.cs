using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.MovieCrawler.Domain.Entities.Experiment
{
    public class HistoricalFeature
    {
        // 감독의 영화 평균평점
        public double DirectorAvgRating { get; set; }

        // 감독 영화 평균 수익
        public double DirectorAvgGross { get; set; }

        // 감독 영화 갯수
        public int DirectorSumMovies { get; set; }

        // 배우들이 참여한 영화의 평균 영화 평점
        public double ActorAvgRating { get; set; }

        // 배우들이 참여한 영화의 평균 영화 수익
        public double ActorAvgGross { get; set; }

        // 배우들이 참여한 영화 갯수
        public int ActorSumMovies { get; set; }

        // 해당 콘텐츠 등급의 영화 평균 평점
        public double ContentRatingAvgRating { get; set; }

        // 해당 콘텐츠 등급의 영화 평균 수익
        public double ContentRatingAvgGross { get; set; }

        // 해당 장르 영화의 평균 평점
        public double GenresAvgRating { get; set; }

        // 해당 장르 영화의 평균 수익
        public double GenresAvgGross { get; set; }

        // 제작사 영화의 평균 평점
        public double CompaniesAvgRating { get; set; }

        // 제작사 영화의 평균 수익
        public double CompaniesAvgGross { get; set; }

        // 제작사가 제작한 영화 갯수
        public int CompaniesSumMovies { get; set; }
    }
}
