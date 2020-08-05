using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.MovieCrawler.Domain.Entities.OMDb
{
    public class Rating
    {
        public String Source { get; set; }
        public String Value { get; set; }
    }
    public class MovieDetail
    {
        public String Title { get; set; }
        public String Year { get; set; }
        public String Rated { get; set; }
        public String Released { get; set; }
        public String Runtime { get; set; }
        public String Genre { get; set; }
        public String Director { get; set; }
        public String Writer { get; set; }
        public String Actors { get; set; }
        public String Plot { get; set; }
        public String Language { get; set; }
        public String Country { get; set; }
        public String Awards { get; set; }
        public String Poster { get; set; }

        public List<Rating> Ratings { get; set; }

        public String Metascore { get; set; }

        public String imdbRating { get; set; }

        public String imdbVotes { get; set; }

        public String imdbID { get; set; }

        public String Type { get; set; }

        public String DVD { get; set; }

        public String BoxOffice { get; set; }

        public String Production { get; set; }

        public String Website { get; set; }

        public String Response { get; set; }
    }
}
