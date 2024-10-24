using Microsoft.AspNetCore.Mvc;
using Inventory.Web.Controllers;

namespace Inventory.Web.Public.Controllers
{
    public class AboutController : InventoryControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}