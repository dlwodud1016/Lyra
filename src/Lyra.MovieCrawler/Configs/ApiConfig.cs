using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace Lyra.MovieCrawler.Configs
{
    // https://github.com/korcosin/MovieCrawler/blob/6392a2e151c8970108e32e17a4522c6266e678a6/CrawlManager/MovieCrawler/Args/Parser.cs
    public class ApiConfig
    {
        public String KobisApiKey { get; set; }
        public String TheMoviedbKey { get; set; }

        public String OMDbKey { get; set; }

        public String KobisApiBoxOfficesUrl { get; set; } = "http://www.kobis.or.kr/kobisopenapi/webservice/rest/boxoffice/searchDailyBoxOfficeList.json";

        #region TMDB
        public String TheMoviedbSearchMovieUrl { get; set; } = "https://api.themoviedb.org/3/search/movie";

        public String TheMoviedbPeopleMovieCreditsUrl { get; set; } = "https://api.themoviedb.org/3/person/{0}/movie_credits";

        public String TheMoviedbCreditDetailUrl { get; set; } = "https://api.themoviedb.org/3/credit/{0}";

        public String TheMoviedbMovieCreditsUrl { get; set; } = "https://api.themoviedb.org/3/movie/{0}/credits";

        public String TheMoviedbMovieDetailUrl { get; set; } = "https://api.themoviedb.org/3/movie/{0}";
        #endregion TMDB

        #region OMDB
        ///?i=tt3896198&apikey=b738d95d
        public String TheOpenMovieDatabaseUrl { get; set; } = "http://www.omdbapi.com";
        #endregion
    }
}
