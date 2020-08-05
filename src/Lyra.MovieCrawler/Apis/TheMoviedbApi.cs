using Lyra.MovieCrawler.Configs;
using Lyra.MovieCrawler.Domain.Entities.TMDB;
using Lyra.MovieCrawler.Features.TMDB;
using Lyra.MovieCrawler.Parameters;
using RestSharp;
using System;

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
        public SearchResponse SearchMovies(String query, int page)
        {
            var client = new RestClient(ConfigManage.ApiConfig.TheMoviedbSearchMovieUrl);
            var request = new RestRequest(Method.GET);

            request.AddParameter(TheMoviedbParameter.Key, ConfigManage.ApiConfig.TheMoviedbKey);
            request.AddParameter(TheMoviedbParameter.Language, "ko");
            request.AddParameter(TheMoviedbParameter.Query, query);
            request.AddParameter(TheMoviedbParameter.Page, page);

            var res = client.Execute<SearchResponse>(request);

            if(res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return res.Data;
            }

            return null;
        }

        public MovieCredit GetMoviesOfPersonId(int personId)
        {
            var client = new RestClient(String.Format(ConfigManage.ApiConfig.TheMoviedbPeopleMovieCreditsUrl, personId));
            var request = new RestRequest(Method.GET);

            request.AddParameter(TheMoviedbParameter.Key, ConfigManage.ApiConfig.TheMoviedbKey);
            request.AddParameter(TheMoviedbParameter.Language, "ko");

            var res = client.Execute(request);

            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return System.Text.Json.JsonSerializer.Deserialize<MovieCredit>(res.Content);
            }

            return null;
        }

        public MovieDetail GetMovieDetail(int movieId)
        {
            var client = new RestClient(String.Format(ConfigManage.ApiConfig.TheMoviedbMovieDetailUrl, movieId));
            var request = new RestRequest(Method.GET);

            request.AddParameter(TheMoviedbParameter.Key, ConfigManage.ApiConfig.TheMoviedbKey);

            var res = client.Execute<MovieDetail>(request);

            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return res.Data;
            }

            return null;
        }

        public MovieCredit GetCreditsOfMovieId(int movieId)
        {
            var client = new RestClient(String.Format(ConfigManage.ApiConfig.TheMoviedbMovieCreditsUrl, movieId));
            var request = new RestRequest(Method.GET);

            request.AddParameter(TheMoviedbParameter.Key, ConfigManage.ApiConfig.TheMoviedbKey);

            var res = client.Execute(request);

            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return System.Text.Json.JsonSerializer.Deserialize<MovieCredit>(res.Content);
            }

            return null;
        }

        public CreditDetailResponse GetCreditDetail(String creditId)
        {
            var client = new RestClient(String.Format(ConfigManage.ApiConfig.TheMoviedbCreditDetailUrl, creditId));
            var request = new RestRequest(Method.GET);

            request.AddParameter(TheMoviedbParameter.Key, ConfigManage.ApiConfig.TheMoviedbKey);

            var res = client.Execute<CreditDetailResponse>(request);

            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return res.Data;
            }

            return null;
        }
    }
}

