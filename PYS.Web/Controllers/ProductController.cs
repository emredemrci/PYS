using Microsoft.AspNetCore.Mvc;

namespace PYS.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Update(int id)
        {
            return View();
        }
    }
}
