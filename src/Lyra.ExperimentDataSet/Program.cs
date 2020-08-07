using Lyra.Domain.Entities.Experiment;
using Lyra.Domain.Entities.TMDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Lyra.ExperimentDataSet
{
    class Program
    {
        private static readonly String movieDetailFileRootPath = @"C:\Users\dlwod\OneDrive\20_대학원\03_졸업논문\Data\영화정보_20200806";
        private static List<MovieDetail> movieDetails = new List<MovieDetail>();

        static void Main(string[] args)
        {
            foreach (var file in Directory.GetFiles(movieDetailFileRootPath))
            {
                String fileName = Path.GetFileNameWithoutExtension(file);
                String title = fileName.Split("_")[0];
                String tmdbId = fileName.Split("_")[2];

                var movieDetail = JsonSerializer.Deserialize<MovieDetail>(System.IO.File.ReadAllText(file));
                movieDetails.Add(movieDetail);
            }

            foreach(var targetMovie in movieDetails)
            {
                FeaturesSet featuresSet = new FeaturesSet()
                {
                    Name = targetMovie.OriginalTitle,
                    TMDbId = targetMovie.Id,
                    IMDbId = targetMovie.ImdbId
                };

                var moviesOfDirector = movieDetails.Where(x => x.OMDbMovieDetail.Director == targetMovie.OMDbMovieDetail.Director);

                featuresSet.HistoricalFeature = new HistoricalFeature()
                {
                    DirectorAvgRating = GetDirecotAvgRating(moviesOfDirector),
                    DirectorAvgGross = GetDirectorAvgGross(moviesOfDirector),
                    DirectorSumMovies = moviesOfDirector.Count(),
                    ActorAvgRating = GetActorAvgRating(targetMovie),
                    ActorAvgGross = GetActorAvgGross(targetMovie),
                    ActorSumMovies = GetActorSumMovies(targetMovie),


                    GenresAvgRating = GetGenresAvgRating(targetMovie),
                    GenresAvgGross = GetGenresAvgGross(targetMovie),
                };
            }
        }


        private static double GetGenresAvgGross(MovieDetail targetMovie)
        {
            Dictionary<String, Double> movieGrossDict = new Dictionary<string, Double>();

            foreach (var genre in targetMovie.Genres)
            {
                foreach (var movie in movieDetails)
                {
                    if (movie.Genres.Exists(x => x.Name.Equals(genre.Name)))
                    {
                        if (movieGrossDict.ContainsKey(movie.ImdbId) == false)
                        {
                            if (movie.Revenue > 0)
                            {
                                movieGrossDict.Add(movie.ImdbId, movie.Revenue);
                            }
                        }
                    }
                }
            }

            return movieGrossDict.Sum(x => x.Value) / movieGrossDict.Count;
        }
        private static double GetGenresAvgRating(MovieDetail targetMovie)
        {
            Dictionary<String, Double> movieRatingDict = new Dictionary<string, Double>();

            foreach (var genre in targetMovie.Genres)
            {
                foreach (var movie in movieDetails)
                {
                    if(movie.Genres.Exists(x => x.Name.Equals(genre.Name)))
                    {
                        if (movieRatingDict.ContainsKey(movie.ImdbId) == false)
                        {
                            movieRatingDict.Add(movie.ImdbId, GetAvgRatingOfMovie(movie));
                        }
                    }
                }
            }

            return movieRatingDict.Sum(x => x.Value) / movieRatingDict.Count;
        }
        private static int GetActorSumMovies(MovieDetail targetMovie)
        {
            Dictionary<String, String> movieDetailDict = new Dictionary<string, String>();

            foreach (var cast in targetMovie.MovieCredit.Casts)
            {
                foreach (var movie in movieDetails)
                {
                    if (movie.MovieCredit.Casts.Exists(x => x.Name == cast.Name))
                    {
                        if (movieDetailDict.ContainsKey(movie.ImdbId) == false)
                        {
                            movieDetailDict.Add(movie.ImdbId, movie.Title);
                        }
                    }
                }
            }

            return movieDetailDict.Count;
        }
        private static double GetActorAvgGross(MovieDetail targetMovie)
        {
            Dictionary<String, Double> movieDetailDict = new Dictionary<string, Double>();

            foreach (var cast in targetMovie.MovieCredit.Casts)
            {
                foreach (var movie in movieDetails)
                {
                    if (movie.MovieCredit.Casts.Exists(x => x.Name == cast.Name))
                    {
                        if (movieDetailDict.ContainsKey(movie.ImdbId) == false)
                        {
                            if(movie.Revenue > 0)
                            {
                                movieDetailDict.Add(movie.ImdbId, movie.Revenue);
                            }
                        }
                    }
                }
            }

            return movieDetailDict.Sum(x => x.Value) / movieDetailDict.Count;
        }
        private static double GetActorAvgRating(MovieDetail targetMovie)
        {
            Dictionary<String, Double> movieDetailDict = new Dictionary<string, Double>();

            foreach(var cast in targetMovie.MovieCredit.Casts)
            {
                foreach (var movie in movieDetails)
                {
                    if(movie.MovieCredit.Casts.Exists(x => x.Name == cast.Name))
                    {
                        if(movieDetailDict.ContainsKey(movie.ImdbId) == false)
                        {
                            movieDetailDict.Add(movie.ImdbId, GetAvgRatingOfMovie(movie));
                        }
                    }
                }
            }

            return movieDetailDict.Sum(x => x.Value) / movieDetailDict.Count;
        }

        private static double GetAvgRatingOfMovie(MovieDetail movieDetail)
        {
            double avgRating = 0;
            foreach (var item in movieDetail.OMDbMovieDetail.Ratings)
            {
                Double doubleRating = 0;
                if (item.Source.Equals("Rotten Tomatoes"))
                {
                    doubleRating = Convert.ToDouble(item.Value.Replace("%", ""))* 0.1;
                }
                else
                {
                    doubleRating = Convert.ToDouble(item.Value.Split("/")[0]);
                }
                
                avgRating += doubleRating;
            }

            if(movieDetail.OMDbMovieDetail.Ratings.Count > 0)
                avgRating = avgRating / movieDetail.OMDbMovieDetail.Ratings.Count;

            return avgRating;
        }
        private static double GetDirectorAvgGross(IEnumerable<MovieDetail> moviesOfDirector)
        {
            double avgGross = 0;
            var movies = moviesOfDirector.Where(x => x.Revenue > 0);
            foreach (var movie in movies)
            {
                avgGross += movie.Revenue;
            }
            if(movies.Count() > 0)
            {
                avgGross = avgGross / movies.Count();
            }

            return avgGross;
        }

        private static double GetDirecotAvgRating(IEnumerable<MovieDetail> moviesOfDirector)
        {
            double avgRating = 0;
            foreach (var movie in moviesOfDirector)
            {
                avgRating += GetAvgRatingOfMovie(movie);
            }

            return avgRating / moviesOfDirector.Count();
        }
    }
}
