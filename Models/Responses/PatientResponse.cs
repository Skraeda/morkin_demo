using PMO.Models.Dtos;

namespace PMO.Models.Responses
{
    public class PatientResponse : Response
    {
        public PatientDto patient { get; set; }
    }
}
