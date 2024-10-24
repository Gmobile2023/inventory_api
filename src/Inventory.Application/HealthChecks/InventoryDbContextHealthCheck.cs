using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Inventory.EntityFrameworkCore;

namespace Inventory.HealthChecks
{
    public class InventoryDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public InventoryDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("InventoryDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("InventoryDbContext could not connect to database"));
        }
    }
}
