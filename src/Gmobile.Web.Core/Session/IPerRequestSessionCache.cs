using System.Threading.Tasks;
using Gmobile.Sessions.Dto;

namespace Gmobile.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
