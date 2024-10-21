using System.Collections.Generic;
using System.Text.Json;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AuthServer.Authorization.Delegation;
using AuthServer.Authorization.Roles;
using AuthServer.Authorization.Users;
using AuthServer.Chat;
using AuthServer.Editions;
using AuthServer.ExtraProperties;
using AuthServer.Friendships;
using AuthServer.MultiTenancy;
using AuthServer.MultiTenancy.Accounting;
using AuthServer.MultiTenancy.Payments;
using AuthServer.OpenIddict.Applications;
using AuthServer.OpenIddict.Authorizations;
using AuthServer.OpenIddict.Scopes;
using AuthServer.OpenIddict.Tokens;
using AuthServer.Storage;

namespace AuthServer.EntityFrameworkCore
{
    public class AuthServerDbContext : AbpZeroDbContext<Tenant, Role, User, AuthServerDbContext>, IOpenIddictDbContext
    {
        /* Define an IDbSet for each entity of the application */

        public virtual DbSet<OpenIddictApplication> Applications { get; }
        
        public virtual DbSet<OpenIddictAuthorization> Authorizations { get; }
        
        public virtual DbSet<OpenIddictScope> Scopes { get; }
        
        public virtual DbSet<OpenIddictToken> Tokens { get; }
        
        public virtual DbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual DbSet<Friendship> Friendships { get; set; }

        public virtual DbSet<ChatMessage> ChatMessages { get; set; }

        public virtual DbSet<SubscribableEdition> SubscribableEditions { get; set; }

        public virtual DbSet<SubscriptionPayment> SubscriptionPayments { get; set; }
        
        public virtual DbSet<SubscriptionPaymentProduct> SubscriptionPaymentProducts { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<UserDelegation> UserDelegations { get; set; }

        public virtual DbSet<RecentPassword> RecentPasswords { get; set; }

        public AuthServerDbContext(DbContextOptions<AuthServerDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BinaryObject>(b => { b.HasIndex(e => new { e.TenantId }); });

            modelBuilder.Entity<SubscriptionPayment>(x =>
            {
                x.Property(u => u.ExtraProperties)
                    .HasConversion(
                        d => JsonSerializer.Serialize(d, new JsonSerializerOptions()
                        {
                            WriteIndented = false
                        }),
                        s => JsonSerializer.Deserialize<ExtraPropertyDictionary>(s, new JsonSerializerOptions()
                        {
                            WriteIndented = false
                        })
                    );
            });
            
            modelBuilder.Entity<SubscriptionPaymentProduct>(x =>
            {
                x.Property(u => u.ExtraProperties)
                    .HasConversion(
                        d => JsonSerializer.Serialize(d, new JsonSerializerOptions()
                        {
                            WriteIndented = false
                        }),
                        s => JsonSerializer.Deserialize<ExtraPropertyDictionary>(s, new JsonSerializerOptions()
                        {
                            WriteIndented = false
                        })
                    );
            });

            modelBuilder.Entity<ChatMessage>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState });
            });

            modelBuilder.Entity<Friendship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId });
                b.HasIndex(e => new { e.TenantId, e.FriendUserId });
                b.HasIndex(e => new { e.FriendTenantId, e.UserId });
                b.HasIndex(e => new { e.FriendTenantId, e.FriendUserId });
            });

            modelBuilder.Entity<Tenant>(b =>
            {
                b.HasIndex(e => new { e.SubscriptionEndDateUtc });
                b.HasIndex(e => new { e.CreationTime });
            });

            modelBuilder.Entity<SubscriptionPayment>(b =>
            {
                b.HasIndex(e => new { e.Status, e.CreationTime });
                b.HasIndex(e => new { PaymentId = e.ExternalPaymentId, e.Gateway });
            });

            modelBuilder.Entity<UserDelegation>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.SourceUserId });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId });
            });
            
            modelBuilder.ConfigureOpenIddict();
        }
    }
}