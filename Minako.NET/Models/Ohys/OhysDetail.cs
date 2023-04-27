using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Minako.NET.Models.Ohys
{
    public class OhysDetail
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("anime_id")]
        public string AnimeId { get; set; }

        [JsonProperty("release_group")]
        public string ReleaseGroup { get; set; }

        [JsonProperty("broadcaster")]
        public string Broadcaster { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("episode")]
        public long Episode { get; set; }

        [JsonProperty("torrent_name")]
        public string TorrentName { get; set; }

        [JsonProperty("info")]
        public DetailInfo Info { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("download")]
        public Download Download { get; set; }
    }

    public class Download
    {
        [JsonProperty("official")]
        public Official Official { get; set; }

        [JsonProperty("mirror")]
        public Mirror Mirror { get; set; }
    }

    public class Mirror
    {
        [JsonProperty("torrent")]
        public Uri Torrent { get; set; }

        [JsonProperty("magnet")]
        public Uri Magnet { get; set; }
    }

    public class Official
    {
        [JsonProperty("torrent")]
        public Uri Torrent { get; set; }
    }

    public class DetailInfo
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("announces")]
        public List<string> Announces { get; set; }

        public Dictionary<string, string> Files { get; set; } = new(); //need to manually set values

        [JsonProperty("files")]
        internal JObject _filesArray { get; set; }
    }
    
}
