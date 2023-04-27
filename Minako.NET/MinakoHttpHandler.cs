using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Minako.NET
{
    internal class MinakoHttpHandler : DelegatingHandler
    {
        public MinakoHttpHandler()
        {
            InnerHandler = new HttpClientHandler();
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.UserAgent.Add(new ProductInfoHeaderValue("Minako.NET", "1.0"));
            var response = await base.SendAsync(request, cancellationToken);
            return response;
        }
    }
}
