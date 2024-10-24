﻿using System;
using Inventory.OpenIddict.Applications;
using Inventory.OpenIddict.Authorizations;
using Inventory.OpenIddict.Scopes;
using Inventory.OpenIddict.Tokens;
using Inventory.Web.OpenIddict.Claims;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenIddict.Core;

namespace Inventory.Web.OpenIddict
{
    public static class OpenIddictRegistrar
    {
        public static void Register(
            IServiceCollection services, 
            IConfigurationRoot configuration,
            Action<OpenIddictCoreOptions> setupOptions)
        {
            services.Configure<AbpOpenIddictClaimsPrincipalOptions>(options =>
            {
                options.ClaimsPrincipalHandlers.Add<AbpDefaultOpenIddictClaimsPrincipalHandler>();
            });

            services.AddOpenIddict()

                // Register the OpenIddict core components.
                .AddCore(builder =>
                {
                    builder
                        .SetDefaultApplicationEntity<OpenIddictApplicationModel>()
                        .SetDefaultAuthorizationEntity<OpenIddictAuthorizationModel>()
                        .SetDefaultScopeEntity<OpenIddictScopeModel>()
                        .SetDefaultTokenEntity<OpenIddictTokenModel>();

                    builder
                        .AddApplicationStore<AbpOpenIddictApplicationStore>()
                        .AddAuthorizationStore<AbpOpenIddictAuthorizationStore>()
                        .AddScopeStore<AbpOpenIddictScopeStore>()
                        .AddTokenStore<AbpOpenIddictTokenStore>();
                })

                // Register the OpenIddict server components.
                .AddServer(options =>
                {
                    // Enable the token endpoint.
                    options.SetAuthorizationEndpointUris("connect/authorize", "connect/authorize/callback")
                        .SetTokenEndpointUris("connect/token")
                        .SetUserinfoEndpointUris("connect/userinfo");

                    // Enable the client credentials flow.
                    options.AllowClientCredentialsFlow();
                    options.AllowPasswordFlow();
                    options.AllowAuthorizationCodeFlow();

                    // Register the signing and encryption credentials.
                    options.AddDevelopmentEncryptionCertificate()
                        .AddDevelopmentSigningCertificate();

                    // Register the ASP.NET Core host and configure the ASP.NET Core options.
                    options.UseAspNetCore()
                        .EnableAuthorizationEndpointPassthrough()
                        .EnableTokenEndpointPassthrough()
                        .EnableUserinfoEndpointPassthrough()
                        .EnableLogoutEndpointPassthrough()
                        .EnableVerificationEndpointPassthrough()
                        .EnableStatusCodePagesIntegration();

                    options.DisableAccessTokenEncryption();
                })

                // Register the OpenIddict validation components.
                .AddValidation(options =>
                {
                    // Import the configuration from the local OpenIddict server instance.
                    options.UseLocalServer();

                    // Register the ASP.NET Core host.
                    options.UseAspNetCore();
                });

            services.AddHostedService<OpenIdDictDataSeedWorker>();
        }

        public static void Register(IServiceCollection services, IConfigurationRoot configuration)
        {
            Register(services, configuration, options => { });
        }
    }
}