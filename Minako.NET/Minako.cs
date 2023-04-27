using System.Text.Json;

namespace Minako.NET
{
    public class Minako
    {
        public HttpClient HttpClient { get; }

        public Minako()
        {
            HttpClient = new HttpClient(new MinakoHttpHandler());
            HttpClient.BaseAddress = new Uri(MinakoConstants.MinakoAPI);
            Initialize();
        }

        public Minako(HttpClient httpClient)
        {
            HttpClient = httpClient;
            Initialize();
        }

        private void Initialize()
        {
            Ohys = new MinakoOhys(HttpClient);
        }

        public MinakoOhys Ohys { get; private set; }
    }
}