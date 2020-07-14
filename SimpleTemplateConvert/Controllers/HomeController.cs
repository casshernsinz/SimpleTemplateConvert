using System.Web.Mvc;

namespace SimpleTemplateConvert.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Title = "About Me";
            ViewBag.Message = "Your app description page.";
            
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TestPage()
        {
            return View();
        }
    }
}
