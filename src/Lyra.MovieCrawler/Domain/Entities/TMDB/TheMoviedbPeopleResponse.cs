using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.MovieCrawler.Domain.Entities.TMDB
{
    public class TheMoviedbPeopleResponse
    {
        public List<TheMoviedbPeopleCast> TheMoviedbPeopleCasts { get; set; }

        public List<TheMoviedbPeopleCrew> TheMoviedbPeopleCrews { get; set; }
    }
}
