using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Forms()
        {
            return View();
        }
        public ActionResult AddLibrary()
        {
            return View();
        }
    }
}
