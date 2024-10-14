using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Gmobile.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
