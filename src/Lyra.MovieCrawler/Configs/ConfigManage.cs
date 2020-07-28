using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Lyra.MovieCrawler.Configs
{
    public class ConfigManage
    {
        public static ApiConfig ApiConfig { get; set; }
        static ConfigManage()
        {
            String jsonString = File.ReadAllText(@"Configs\ApiConfig.json");
            ApiConfig = JsonSerializer.Deserialize<ApiConfig>(jsonString);
        }
    }
}
