using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace streams
{

    public class SentimentResponse
    {
        [JsonProperty(PropertyName = "documents")]
        public List<SentimentDocument> SentimentDocument { get; set; }
        public object[] errors { get; set; }
        public string modelVersion { get; set; }
    }

    public class SentimentDocument
    {
        public string id { get; set; }
        public string sentiment { get; set; }
        public Confidencescores confidenceScores { get; set; }
        public Sentence[] sentences { get; set; }
        public object[] warnings { get; set; }
    }

    public class Confidencescores
    {
        public float positive { get; set; }
        public float neutral { get; set; }
        public float negative { get; set; }
    }

    public class Sentence
    {
        public string sentiment { get; set; }
        public Confidencescores1 confidenceScores { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
        public string text { get; set; }
    }

    public class Confidencescores1
    {
        public float positive { get; set; }
        public float neutral { get; set; }
        public float negative { get; set; }
    }

}
