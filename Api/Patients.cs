using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PMO.Interfaces;
using PMO.Models.Inputs;
using PMO.Models.Requests;
using PMO.Models.Responses;

namespace PMO.Api
{
    public class Patients : Api, IPatients
    {
        public Patients(HttpClient client, string token): base(client, token) { }

        public async Task<PatientResponse> GetPatient(string codenumber)
        {
            Request request = new Request { token = this.token };
            var response = await this.PostRequest("patient/" + codenumber + "/get", request);
            return JsonConvert.DeserializeObject<PatientResponse>(response);
        }

        public async Task<PatientResponse> UpdatePatient(string codenumber, PatientInput patient)
        {
            PatientRequest request = new PatientRequest { token = this.token, patient = patient };
            var response = await this.PostRequest("patient/" + codenumber + "/update", request);
            return JsonConvert.DeserializeObject<PatientResponse>(response);
        }
    }
}
