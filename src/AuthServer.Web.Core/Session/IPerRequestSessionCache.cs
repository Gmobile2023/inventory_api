using System.Threading.Tasks;
using AuthServer.Sessions.Dto;

namespace AuthServer.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
