using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using Practice.Models;
using var connection = new MySqlConnection(" Server=localhost;User ID=root; Password=1111;Database=Library");
namespace Practice.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Forms()
        {
            return View();

        }
        public IActionResult Tables()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddLibrary(LibraryData libraryData)
        {
            if(ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Forms");
        }
    }
}
