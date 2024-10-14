using Microsoft.EntityFrameworkCore;
using Gmobile.OpenIddict.Applications;
using Gmobile.OpenIddict.Authorizations;
using Gmobile.OpenIddict.Scopes;
using Gmobile.OpenIddict.Tokens;

namespace Gmobile.EntityFrameworkCore
{
    public interface IOpenIddictDbContext
    {
        DbSet<OpenIddictApplication> Applications { get; }

        DbSet<OpenIddictAuthorization> Authorizations { get; }

        DbSet<OpenIddictScope> Scopes { get; }

        DbSet<OpenIddictToken> Tokens { get; }
    }

}