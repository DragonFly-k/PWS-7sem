using System.Web.Mvc;
namespace lab2.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}