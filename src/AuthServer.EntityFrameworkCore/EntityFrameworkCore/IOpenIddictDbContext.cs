using Microsoft.EntityFrameworkCore;
using AuthServer.OpenIddict.Applications;
using AuthServer.OpenIddict.Authorizations;
using AuthServer.OpenIddict.Scopes;
using AuthServer.OpenIddict.Tokens;

namespace AuthServer.EntityFrameworkCore
{
    public interface IOpenIddictDbContext
    {
        DbSet<OpenIddictApplication> Applications { get; }

        DbSet<OpenIddictAuthorization> Authorizations { get; }

        DbSet<OpenIddictScope> Scopes { get; }

        DbSet<OpenIddictToken> Tokens { get; }
    }

}