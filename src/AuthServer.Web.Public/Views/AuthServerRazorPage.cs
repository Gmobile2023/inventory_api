using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace AuthServer.Web.Public.Views
{
    public abstract class AuthServerRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AuthServerRazorPage()
        {
            LocalizationSourceName = AuthServerConsts.LocalizationSourceName;
        }
    }
}
