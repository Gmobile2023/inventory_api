using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Inventory.Web.Controllers;

namespace Inventory.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize]
    public class WelcomeController : InventoryControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}