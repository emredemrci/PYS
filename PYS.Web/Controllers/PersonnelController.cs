using Microsoft.AspNetCore.Mvc;

namespace PYS.Web.Controllers
{
    public class PersonnelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        //personnnel/update/5
        public IActionResult Update(int id)
        {
            return View();
        }
    }
}
