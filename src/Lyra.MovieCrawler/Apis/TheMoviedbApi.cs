using Lyra.MovieCrawler.Configs;
using Lyra.MovieCrawler.Domain.Entities;
using Lyra.MovieCrawler.Parameters;
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
        public TheMoviedbSearchResponse SearchMovies(String query, int page)
        {
            var client = new RestClient(ConfigManage.ApiConfig.TheMoviedbSearchMovieUrl);
            var request = new RestRequest(Method.GET);

            request.AddParameter(TheMoviedbParameter.Key, ConfigManage.ApiConfig.TheMoviedbKey);
            request.AddParameter(TheMoviedbParameter.Language, "ko");
            request.AddParameter(TheMoviedbParameter.Query, query);
            request.AddParameter(TheMoviedbParameter.Page, page);

            var res = client.Execute<TheMoviedbSearchResponse>(request);

            if(res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return res.Data;
            }

            return null;
        }

        public void GetMovieDetail(DateTime targetDt)
        {

        }
    }
}

