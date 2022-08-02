using Microsoft.AspNetCore.Mvc;

namespace GuidingLightBookGallery.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public ActionResult Details()
        {
            return View();
        }
    }
}
