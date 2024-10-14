using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Gmobile.EntityFrameworkCore;

namespace Gmobile.HealthChecks
{
    public class GmobileDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public GmobileDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("GmobileDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("GmobileDbContext could not connect to database"));
        }
    }
}
