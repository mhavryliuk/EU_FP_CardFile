using System.Web.Mvc;
using System.Web.UI;

namespace CardFile.Controllers
{
    // Duration: продолжительность кэширования контента в секундах.
    // Location: место, где размещается кэшированный контент.
    // Downstream: контент кэшируется как на клиенте, так и на прокси-сервере. Выходной кэш сервера не используется.
    [OutputCache(Duration = 120, Location = OutputCacheLocation.Downstream)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "О библиотеке";

            return View();
        }
        
        public ActionResult Contact()
        {
            ViewBag.Message = "Контакты";

            return View();
        }
    }
}