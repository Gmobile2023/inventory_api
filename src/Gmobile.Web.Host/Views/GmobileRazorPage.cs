using Abp.AspNetCore.Mvc.Views;

namespace Gmobile.Web.Views
{
    public abstract class GmobileRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected GmobileRazorPage()
        {
            LocalizationSourceName = GmobileConsts.LocalizationSourceName;
        }
    }
}
