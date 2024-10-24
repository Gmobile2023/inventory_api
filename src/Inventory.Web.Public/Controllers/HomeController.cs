using Microsoft.AspNetCore.Mvc;
using Inventory.Web.Controllers;

namespace Inventory.Web.Public.Controllers
{
    public class HomeController : InventoryControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}