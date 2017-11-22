using Microsoft.AspNetCore.Mvc;

namespace Birthday.Web.Controllers
{
    public class HomeController : BirthdayControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}