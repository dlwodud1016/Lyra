using Lyra.MovieCrawler.Domain.Entities.TMDB;
using System.Collections.Generic;

namespace Lyra.MovieCrawler.Features.TMDB
{
    public class PeopleResponse
    {
        public List<PeopleCast> TheMoviedbPeopleCasts { get; set; }

        public List<PeopleCrew> TheMoviedbPeopleCrews { get; set; }
    }
}
