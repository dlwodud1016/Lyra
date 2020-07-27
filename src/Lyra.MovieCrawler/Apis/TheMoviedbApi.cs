using Lyra.MovieCrawler.Configs;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.MovieCrawler.Apis
{
    /// <summary>
    /// TMDB
    /// https://developers.themoviedb.org/3/
    /// </summary>  
    public class TheMoviedbApi
    {
        private String _rootPathUrl = "https://developers.themoviedb.org/3/";

        // https://api.themoviedb.org/3/search/movie?api_key=87d005a0c25e9efb0f7e39a80d51143d&language=ko&query=괴물&page=1
        public void SearchMovies(String query)
        {
            var client = new RestClient(ApiConfig.TheMoviedbSearchMovieUrl);
            var request = new RestRequest(Method.GET);

            request.AddParameter()
        }
        public void GetMovieDetail(DateTime targetDt)
        {

        }
    }
}
