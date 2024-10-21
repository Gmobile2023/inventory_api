using System.Threading.Tasks;

namespace AuthServer.Web.OpenIddict.Claims
{
    public interface IAbpOpenIddictClaimsPrincipalHandler
    {
        Task HandleAsync(AbpOpenIddictClaimsPrincipalHandlerContext context);
    }
}