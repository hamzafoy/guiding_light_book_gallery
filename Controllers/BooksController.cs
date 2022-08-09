using GuidingLightBookGallery.Data;
using GuidingLightBookGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuidingLightBookGallery.Controllers
{
    public class BooksController : Controller
    {
        private BookRepository _bookRepository = null;
        public BooksController()
        {
            _bookRepository = new BookRepository();
        }
        public IActionResult Index()
        {
            var books = _bookRepository.GetBooks();
            return View(books);
        }

        public ActionResult Details(int id)
        {
            var book = _bookRepository.GetBook(id);

            return View(book);
        }
    }
}
