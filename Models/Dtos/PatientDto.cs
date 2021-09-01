using PMO.Interfaces;

namespace PMO.Models.Dtos
{
    public class PatientDto
    {
        public string codenumber { get; set; }

        public string birthPlace { get; set; }

        public string job { get; set; }

        public string ward { get; set; }

        public string photo { get; set; }

        public RelativeDto[] relatives { get; set; }
    }
}
