using System.Net.Http;
using System.Threading.Tasks;
using PMO.Models.Requests;
using Newtonsoft.Json;
using System.Text;

namespace PMO.Api
{
    abstract public class Api
    {
        protected readonly HttpClient client;

        protected string token;

        public Api(HttpClient client, string token)
        {
            this.client = client;
            this.token = token;
        }

        protected async Task<string> PostRequest(string endpoint, Request request)
        {
            var json = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await this.client.PostAsync(endpoint, stringContent);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
