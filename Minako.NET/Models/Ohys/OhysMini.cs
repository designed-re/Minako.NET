using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Minako.NET.Models.Ohys
{
    public class OhysMini
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("release_group")]
        public string ReleaseGroup { get; set; }

        [JsonProperty("broadcaster")]
        public string Broadcaster { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("episode")]
        public int? TotalEpisodes { get; set; }

        [JsonProperty("torrent_name")]
        public string TorrentName { get; set; }

        [JsonProperty("info")]
        public Info Info { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }
    }

    public class Info
    {
        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
    }
}
