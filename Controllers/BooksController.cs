using GuidingLightBookGallery.Models;
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
            var book = new Book()
            {
                Title = "Islam and the World",
                Authors = new Author[]
                {
                        new Author() { FirstName = "Sayyed Abul Hasan", LastName = "Ali Nadwi", Role = "Author" },
                        new Author() { FirstName = "Muhammad", LastName = "Kidwai", Role = "Translator" }
                },
                DescriptionHTML = "<p>This book persuasively argues against the premise that Islam is a <em>spent force</em>, reminding readers of its dynamism.</p>",
                PublishingHouse = "UK Islamic Academy",
                PublicationYear = 2005
            };
            //ViewBag.Title = "Islam and the World";
            //ViewBag.Authors = new string[]
            //{
            //    "Author: Sayyed Abul Hasan Ali Nadwi",
            //    "Translator: Dr. Muhammad Kidwai"
            //};
            //ViewBag.Description = 
            //ViewBag.PublishingHouse = "UK Islamic Academy";
            //ViewBag.PublicationYear = 2005;
            return View(book);
        }
    }
}
