using Abp.AspNetCore.Mvc.ViewComponents;

namespace AuthServer.Web.Public.Views
{
    public abstract class AuthServerViewComponent : AbpViewComponent
    {
        protected AuthServerViewComponent()
        {
            LocalizationSourceName = AuthServerConsts.LocalizationSourceName;
        }
    }
}