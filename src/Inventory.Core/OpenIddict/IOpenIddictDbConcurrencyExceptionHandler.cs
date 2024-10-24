using System.Threading.Tasks;
using Abp.Domain.Uow;

namespace Inventory.OpenIddict
{
    public interface IOpenIddictDbConcurrencyExceptionHandler
    {
        Task HandleAsync(AbpDbConcurrencyException exception);
    }
}