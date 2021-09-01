using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PMO.Interfaces;
using PMO.Api;
using PMO.Models.Responses;
using PMO.Models.Inputs;

namespace PMO
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Demo();
        }

        private static async Task Demo()
        {
            string baseUrl = "http://localhost:8080/api/";
            string token = "B774489D458165657CCC4FD01E44F1D92E5CCD3C";

            IPMO pmo = new PMOApi(baseUrl, token);

            // var patientRes = await pmo.Patients.UpdatePatient("1111111119", new PatientInput
            // {
            //     job = "Veiðimaður",
            //     birthPlace = "Reykjavik"
            // });

            // var relativeRes = await pmo.Relatives.StoreRelative("1111111119", new RelativeInput
            // {
            //     name = "CSharp",
            //     mobilePhone = "8230668",
            //     email = "gunnar@sjukraskra.is" 
            // });

            // Console.WriteLine(JsonConvert.SerializeObject(patientRes));
            // Console.WriteLine(JsonConvert.SerializeObject(relativeRes));
       }
    }
}
