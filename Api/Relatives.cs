using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PMO.Interfaces;
using PMO.Models.Inputs;
using PMO.Models.Requests;
using PMO.Models.Responses;

namespace PMO.Api
{
    public class Relatives : Api, IRelatives
    {
        public Relatives(HttpClient client, string token): base(client, token) { }

        public async Task<RelativeCollectionResponse> GetRelatives(string codenumber)
        {
            Request request = new Request { token = this.token };
            var response = await this.PostRequest("patient/" + codenumber + "/relatives/index", request);
            return JsonConvert.DeserializeObject<RelativeCollectionResponse>(response);
        }

        public async Task<RelativeResponse> StoreRelative(string codenumber, RelativeInput relative)
        {
            RelativeRequest request = new RelativeRequest { token = this.token, relative = relative };
            var response = await this.PostRequest("patient/" + codenumber + "/relatives/store", request);
            return JsonConvert.DeserializeObject<RelativeResponse>(response);
        }
    }
}
