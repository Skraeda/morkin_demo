using System.Threading.Tasks;
using PMO.Models.Inputs;
using PMO.Models.Responses;

namespace PMO.Interfaces
{
    public interface IRelatives
    {
        Task<RelativeResponse> StoreRelative(string codenumber, RelativeInput relative);
        
        Task<RelativeCollectionResponse> GetRelatives(string codenumber);
    }
}
