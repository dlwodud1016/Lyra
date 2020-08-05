using Lyra.MovieCrawler.Apis;
using Lyra.MovieCrawler.Domain.Entities.TMDB;
using System;
using System.Linq;

namespace Lyra.MovieCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            KobisApi kobisApi = new KobisApi();
            TheMoviedbApi theMoviedbApi = new TheMoviedbApi();
            OMDbApi omdbApi = new OMDbApi();

            Console.WriteLine("Hello World!");


            DateTime target = DateTime.Now;
            while(target.Year >= 2020)
            {
                var boxOffices = kobisApi.GetBoxOffices(target);
                foreach(var boxOffice in boxOffices.BoxOfficeResult.DailyBoxOfficeList)
                {
                    var searchMovies = theMoviedbApi.SearchMovies(boxOffice.MovieNm, 1);

                    var movieId = searchMovies.Results.First().Id;

                    MovieDetail movieDetail = theMoviedbApi.GetMovieDetail(movieId);
                    if(movieDetail != null)
                    {
                        movieDetail.MovieCredit = theMoviedbApi.GetCreditsOfMovieId(movieId);

                        foreach(var cast in movieDetail.MovieCredit.Casts)
                        {
                            movieDetail.MovieCredit = theMoviedbApi.GetMoviesOfPersonId(cast.Id);
                        }

                        var omdbMovieDetail = omdbApi.GetMovieDetail(movieDetail.ImdbId);
                    }
                    
                }

                target = target.AddDays(-1);
            }

            
            
        }
    }
}
