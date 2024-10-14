using Microsoft.AspNetCore.Mvc;
using Gmobile.Web.Controllers;

namespace Gmobile.Web.Public.Controllers
{
    public class HomeController : GmobileControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}