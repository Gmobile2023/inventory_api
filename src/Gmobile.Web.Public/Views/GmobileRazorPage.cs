using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Gmobile.Web.Public.Views
{
    public abstract class GmobileRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected GmobileRazorPage()
        {
            LocalizationSourceName = GmobileConsts.LocalizationSourceName;
        }
    }
}
