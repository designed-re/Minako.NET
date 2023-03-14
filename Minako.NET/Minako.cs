namespace Minako.NET
{
    public class Minako
    {
        public HttpClient HttpClient { get; }

        public Minako()
        {
            HttpClient = new();
            HttpClient.BaseAddress = new Uri("https://api.minako.moe");
            
        }

        public Minako(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
    }
}