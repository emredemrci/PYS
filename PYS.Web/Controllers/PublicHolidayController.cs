using Microsoft.AspNetCore.Mvc;

namespace PYS.Web.Controllers
{
    public class PublicHolidayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
