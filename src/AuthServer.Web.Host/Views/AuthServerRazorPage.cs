using Abp.AspNetCore.Mvc.Views;

namespace AuthServer.Web.Views
{
    public abstract class AuthServerRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected AuthServerRazorPage()
        {
            LocalizationSourceName = AuthServerConsts.LocalizationSourceName;
        }
    }
}
