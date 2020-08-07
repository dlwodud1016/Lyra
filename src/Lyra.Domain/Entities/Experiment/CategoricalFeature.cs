using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Domain.Entities.Experiment
{
    public class CategoricalFeature
    {
        // 영화 장르
        public List<String> Genres { get; set; }

        // 영화 콘텐츠 등급
        public String ContentRating { get; set; }
    }
}
