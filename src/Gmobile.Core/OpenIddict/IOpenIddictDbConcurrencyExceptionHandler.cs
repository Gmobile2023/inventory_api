using System.Threading.Tasks;
using Abp.Domain.Uow;

namespace Gmobile.OpenIddict
{
    public interface IOpenIddictDbConcurrencyExceptionHandler
    {
        Task HandleAsync(AbpDbConcurrencyException exception);
    }
}