using PMO.Interfaces;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace PMO.Api
{
    public class PMOApi : IPMO
    {
        protected readonly HttpClient client;

        protected IPatients patients;

        protected IRelatives relatives;

        protected string url;

        protected string token;

        public PMOApi(string url, string token)
        {
            HttpClient client = new HttpClient();
            
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            this.client = client;
            this.token = token;
        }

        public IPatients Patients => this.patients ??= new Patients(this.client, this.token);

        public IRelatives Relatives => this.relatives ??= new Relatives(this.client, this.token);
    }
}