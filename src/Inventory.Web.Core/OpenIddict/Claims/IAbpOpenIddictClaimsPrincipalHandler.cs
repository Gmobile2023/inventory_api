using System.Threading.Tasks;

namespace Inventory.Web.OpenIddict.Claims
{
    public interface IAbpOpenIddictClaimsPrincipalHandler
    {
        Task HandleAsync(AbpOpenIddictClaimsPrincipalHandlerContext context);
    }
}