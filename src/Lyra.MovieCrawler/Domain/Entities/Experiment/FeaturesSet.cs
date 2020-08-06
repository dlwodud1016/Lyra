using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.MovieCrawler.Domain.Entities.Experiment
{
    public class FeaturesSet
    {
        public String OMDbId { get; set; }
        public String TMDbId { get; set; }
        public String Name { get; set; }

        public HistoricalFeature HistoricalFeature { get; set; }

        public MetadataFeature MetadataFeature { get; set; }

        public CategoricalFeature CategoricalFeature { get; set; }

        public SourceOfTopicalFeature SourceOfTopicalFeature { get; set; }
    }
}
