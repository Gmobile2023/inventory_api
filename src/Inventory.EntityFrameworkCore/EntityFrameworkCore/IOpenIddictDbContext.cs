using Inventory.OpenIddict.Applications;
using Inventory.OpenIddict.Authorizations;
using Inventory.OpenIddict.Scopes;
using Inventory.OpenIddict.Tokens;
using Microsoft.EntityFrameworkCore;

namespace Inventory.EntityFrameworkCore
{
    public interface IOpenIddictDbContext
    {
        DbSet<OpenIddictApplication> Applications { get; }

        DbSet<OpenIddictAuthorization> Authorizations { get; }

        DbSet<OpenIddictScope> Scopes { get; }

        DbSet<OpenIddictToken> Tokens { get; }
    }

}