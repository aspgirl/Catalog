using Catalog.Core;
using System.Web.Mvc;

namespace Catalog.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dataService = DataService.GetInstance();

            return View(dataService.Teams);
        }
    }
}