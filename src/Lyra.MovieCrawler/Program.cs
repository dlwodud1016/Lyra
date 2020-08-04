using Lyra.MovieCrawler.Apis;
using System;

namespace Lyra.MovieCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            KobisApi kobisApi = new KobisApi();
            TheMoviedbApi theMoviedbApi = new TheMoviedbApi();

            DateTime target = DateTime.Now;
            while(target.Year >= 2020)
            {
                var boxOffices = kobisApi.GetBoxOffices(target);
                foreach(var boxOffice in boxOffices.BoxOfficeResult.DailyBoxOfficeList)
                {
                    var searchMovies = theMoviedbApi.SearchMovies(boxOffice.MovieNm, 1);
                    
                }
            }

            
            
        }
    }
}
