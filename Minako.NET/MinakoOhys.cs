﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minako.NET.Models.Ohys;
using Minako.NET.Response;
using Minako.NET.Response.Ohys;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Minako.NET
{
    public class MinakoOhys
    {
        private HttpClient _client;
        public MinakoOhys(HttpClient client)
        {
            _client = client;
        }

        public async Task<OhysIndexResponse> GetOhysIndexAsync(int page = 1)
        {
            var response = await _client.GetAsync(Path.Combine(MinakoConstants.MinakoAPI, MinakoConstants.OhysRoute));
            response.EnsureSuccessStatusCode();

            var responseStr = await response.Content.ReadAsStringAsync();

            var model = JsonConvert.DeserializeObject<OhysIndexResponse>(responseStr);

            return model;
        }

        public async Task<OhysDetail> GetOhysDetailAsync(OhysMini mini)
        {
            var response =
                await _client.GetAsync(
                    string.Format(Path.Combine(MinakoConstants.MinakoAPI, MinakoConstants.OhysDetailRoute), mini.Id));
            response.EnsureSuccessStatusCode();

            var responseStr = await response.Content.ReadAsStringAsync();

            var model = JsonConvert.DeserializeObject<OhysDetail>(responseStr);

            foreach (var kv in model.Info._filesArray)
            {
                model.Info.Files.Add(kv.Key, kv.Value.Value<string>());
            }

            return model;
        }

        public async Task<OhysDetail> GetOhysDetailAsync(int id)
        {
            var response =
                await _client.GetAsync(
                    string.Format(Path.Combine(MinakoConstants.MinakoAPI, MinakoConstants.OhysDetailRoute), id));
            response.EnsureSuccessStatusCode();

            var responseStr = await response.Content.ReadAsStringAsync();

            var model = JsonConvert.DeserializeObject<OhysDetail>(responseStr);

            foreach (var kv in model.Info._filesArray)
            {
                model.Info.Files.Add(kv.Key, kv.Value.Value<string>());
            }

            return model;
        }
    }
}