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

            //kobisApi.GetBoxOffices(DateTime.Now);
            theMoviedbApi.SearchMovies("괴물", 1);
        }
    }
}
