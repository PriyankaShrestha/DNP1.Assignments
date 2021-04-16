using System.Net.Http;

namespace Blazor.Data
{
    public abstract class Client
    {
        private HttpClient client;
        private string uri = "http://localhost:5006";

        public Client()
        {
            client = new HttpClient();
        }
    }
}