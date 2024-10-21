using System.Threading.Tasks;
using Abp.Domain.Uow;

namespace AuthServer.OpenIddict
{
    public interface IOpenIddictDbConcurrencyExceptionHandler
    {
        Task HandleAsync(AbpDbConcurrencyException exception);
    }
}