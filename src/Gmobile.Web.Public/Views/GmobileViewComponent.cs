using Abp.AspNetCore.Mvc.ViewComponents;

namespace Gmobile.Web.Public.Views
{
    public abstract class GmobileViewComponent : AbpViewComponent
    {
        protected GmobileViewComponent()
        {
            LocalizationSourceName = GmobileConsts.LocalizationSourceName;
        }
    }
}