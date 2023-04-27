using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minako.NET.Models.Ohys
{
    public class Metadata
    {
        [JsonProperty("video")]
        public Video Video { get; set; }

        [JsonProperty("audio")]
        public Audio Audio { get; set; }
    }

    public class Audio
    {
        [JsonProperty("codec")]
        public string Codec { get; set; }
    }

    public class Video
    {
        [JsonProperty("codec")]
        public string Codec { get; set; }

        [JsonProperty("resolution")]
        public string Resolution { get; set; }
    }
}
