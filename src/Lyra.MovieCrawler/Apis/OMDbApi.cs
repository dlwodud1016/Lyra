using Lyra.MovieCrawler.Configs;
using Lyra.MovieCrawler.Domain.Entities.OMDb;
using Lyra.MovieCrawler.Parameters;
using RestSharp;
using System;

namespace Lyra.MovieCrawler.Apis
{
    public class OMDbApi
    {
        public MovieDetail GetMovieDetail(String movieId)
        {
            var client = new RestClient(ConfigManage.ApiConfig.TheOpenMovieDatabaseUrl);
            var request = new RestRequest(Method.GET);

            request.AddParameter(OMDbParameter.Id, movieId);
            request.AddParameter(OMDbParameter.Apikey, ConfigManage.ApiConfig.OMDbKey);

            var res = client.Execute<MovieDetail>(request);

            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return res.Data;
            }

            return null;
        }
    }
}
