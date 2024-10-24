using System.Threading.Tasks;
using Inventory.Sessions.Dto;

namespace Inventory.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
