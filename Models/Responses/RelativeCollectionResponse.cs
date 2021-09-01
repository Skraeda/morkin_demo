using PMO.Models.Dtos;

namespace PMO.Models.Responses
{
    public class RelativeCollectionResponse : Response
    {
        public RelativeDto[] relatives { get; set; }
    }
}
