using System.Threading.Tasks;
using Abp.Dependency;

namespace Gmobile.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}