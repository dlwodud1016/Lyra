using System;
using System.Collections.Generic;
using System.Text;

namespace Lyra.Domain.Entities.Experiment
{
    public class FeaturesSet
    {
        public String IMDbId { get; set; }
        public int TMDbId { get; set; }
        public String Name { get; set; }

        public HistoricalFeature HistoricalFeature { get; set; }

        public MetadataFeature MetadataFeature { get; set; }

        public CategoricalFeature CategoricalFeature { get; set; }

        public SourceOfTopicalFeature SourceOfTopicalFeature { get; set; }
    }
}
