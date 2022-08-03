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
            ViewBag.Title = "Islam and the World";
            ViewBag.Authors = new string[]
            {
                "Author: Sayyed Abul Hasan Ali Nadwi",
                "Translator: Dr. Muhammad Kidwai"
            };
            ViewBag.Description = "<p>This book persuasively argues against the premise that Islam is a <em>spent force</em>, reminding readers of its dynamism.</p>";
            ViewBag.PublishingHouse = "UK Islamic Academy";
            ViewBag.PublicationYear = 2005;
            return View();
        }
    }
}
