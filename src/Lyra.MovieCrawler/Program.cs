using Lyra.Domain.Entities.TMDB;
using Lyra.MovieCrawler.Apis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Lyra.MovieCrawler
{
    class Program
    {
        static String saveFileRootPath = @"C:\Users\dlwod\OneDrive\20_대학원\03_졸업논문\Data\영화정보_20200806";
        static Dictionary<String, String> saveMovieDict = new Dictionary<string, string>();
        static KobisApi _kobisApi = new KobisApi();
        static TheMoviedbApi _theMoviedbApi = new TheMoviedbApi();
        static OMDbApi _omdbApi = new OMDbApi();

        static Program()
        {
            foreach(var file in Directory.GetFiles(saveFileRootPath))
            {
                String fileName = Path.GetFileNameWithoutExtension(file);
                String title = fileName.Split("_")[0];
                String tmdbId = fileName.Split("_")[2];

                saveMovieDict.Add(tmdbId, title);
            }
        }
        private static string GetValidFileName(string fileName)
        {
            // remove any invalid character from the filename.
            return Regex.Replace(fileName.Trim(), "[^가-힣A-Za-z0-9_ ]+", "");
        }

        private static void SaveMovie(int movieId)
        {
            MovieDetail movieDetail = _theMoviedbApi.GetMovieDetail(movieId);
            if (movieDetail != null && movieDetail.ImdbId != String.Empty && movieDetail.ImdbId != null)
            {
                if (saveMovieDict.ContainsKey(movieDetail.ImdbId))
                {
                    return; ;
                }

                movieDetail.MovieCredit = _theMoviedbApi.GetCreditsOfMovieId(movieId);

                //foreach(var cast in movieDetail.MovieCredit.Casts)
                //{
                //    movieDetail.MovieCredit = theMoviedbApi.GetMoviesOfPersonId(cast.Id);
                //}

                movieDetail.OMDbMovieDetail = _omdbApi.GetMovieDetail(movieDetail.ImdbId);
                if (movieDetail.OMDbMovieDetail == null)
                {
                    Console.WriteLine("OMDbMovie end");
                    return;
                }
                String jsonString = JsonSerializer.Serialize(movieDetail);
                String validFileName = GetValidFileName(movieDetail.OriginalTitle).Trim();
                if (validFileName != String.Empty && validFileName != null)
                {
                    System.IO.File.WriteAllText(Path.Combine(saveFileRootPath, $"{validFileName}_{movieDetail.ReleaseDate}_{movieDetail.ImdbId}.json"), jsonString);

                    saveMovieDict.Add(movieDetail.ImdbId, validFileName);

                    Console.WriteLine($"Save {validFileName} / {movieDetail.ReleaseDate}");
                }
            }
        }
        private static void CrawlerMoviesOfBoxOffice()
        {
            DateTime target = DateTime.Now;
            while (target.Year > 2000)
            {
                var boxOffices = _kobisApi.GetBoxOffices(target);
                foreach (var boxOffice in boxOffices.BoxOfficeResult.DailyBoxOfficeList)
                {
                    var searchMovies = _theMoviedbApi.SearchMovies(boxOffice.MovieNm, 1);

                    if (searchMovies.Results.Count > 0)
                    {
                        var movieId = searchMovies.Results.First().Id;

                        SaveMovie(movieId);
                    }
                }

                target = target.AddDays(-7);
            }
        }

        private static void CrawlerMoviesOfCredits()
        {
            foreach (var file in Directory.GetFiles(saveFileRootPath))
            {
                var movieDetail = JsonSerializer.Deserialize<MovieDetail>(System.IO.File.ReadAllText(file));

                foreach(var cast in movieDetail.MovieCredit.Casts)
                {
                    var movieCredit = _theMoviedbApi.GetMoviesOfPersonId(cast.Id);

                    foreach(var creditCast in movieCredit.Casts)
                    {
                        SaveMovie(creditCast.Id);
                    }

                    foreach(var creditCrew in movieCredit.Crews)
                    {
                        SaveMovie(creditCrew.Id);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //CrawlerMoviesOfBoxOffice();

            CrawlerMoviesOfCredits();
        }
    }
}
