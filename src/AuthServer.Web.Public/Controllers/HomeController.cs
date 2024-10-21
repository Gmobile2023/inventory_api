using Microsoft.AspNetCore.Mvc;
using AuthServer.Web.Controllers;

namespace AuthServer.Web.Public.Controllers
{
    public class HomeController : AuthServerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}