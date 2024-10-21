using Microsoft.AspNetCore.Mvc;
using AuthServer.Web.Controllers;

namespace AuthServer.Web.Public.Controllers
{
    public class AboutController : AuthServerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}