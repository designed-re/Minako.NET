using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minako.NET.Response
{
    public class MinakoBaseResponse<T>
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("items")]
        public T[] Items { get; set; }
    }


    public class Pagination
    {
        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("current")]
        public long Current { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }
}
