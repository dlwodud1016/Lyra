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

            kobisApi.GetBoxOffices(DateTime.Now);
        }
    }
}
