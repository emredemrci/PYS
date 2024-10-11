using Microsoft.AspNetCore.Mvc;

namespace PYS.Web.Controllers
{
    public class AnnualLeave : Controller
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
