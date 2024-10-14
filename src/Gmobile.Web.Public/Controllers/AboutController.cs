using Microsoft.AspNetCore.Mvc;
using Gmobile.Web.Controllers;

namespace Gmobile.Web.Public.Controllers
{
    public class AboutController : GmobileControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}