﻿using Lyra.Domain.Entities.Kobis;
using Lyra.MovieCrawler.Configs;
using Lyra.MovieCrawler.Parameters;
using RestSharp;
using System;

namespace Lyra.MovieCrawler.Apis
{
    /// <summary>
    /// 영화관입장권통합전상망 오픈 API
    /// http://www.kobis.or.kr/kobisopenapi/homepg/board/findTutorial.do

    /// </summary>
    public class KobisApi
    {   
        public KobisBoxOfficeResponse GetBoxOffices(DateTime targetDt)
        {
            var client = new RestClient(ConfigManage.ApiConfig.KobisApiBoxOfficesUrl);
            var request = new RestRequest(Method.GET);

            request.AddParameter(KobisParameter.Key, ConfigManage.ApiConfig.KobisApiKey);
            request.AddParameter(KobisParameter.TargetDate, targetDt.ToString("yyyyMMdd"));
            request.AddParameter(KobisParameter.MultiMovieYn, "N");
            request.AddParameter(KobisParameter.RepNationCd, "K");

            var res = client.Execute<KobisBoxOfficeResponse>(request);

            if(res.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return res.Data;
            }

            return null;
        }

        

    }
}
