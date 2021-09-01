using System.Threading.Tasks;
using PMO.Models.Inputs;
using PMO.Models.Responses;

namespace PMO.Interfaces
{
    public interface IPatients
    {
        Task<PatientResponse> GetPatient(string codenumber);

        Task<PatientResponse> UpdatePatient(string codenumber, PatientInput patient);
    }
}
