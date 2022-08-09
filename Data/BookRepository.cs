using GuidingLightBookGallery.Models;

namespace GuidingLightBookGallery.Data
{
    public class BookRepository
    {
        private static Book[] _books = new Book[]
        {
        new Book()
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
            }
        };
        public Book GetBook(int id)
        {
            Book returnedBook = null;
            foreach (var book in _books)
            {
                if(book.Id == id)
                {
                    returnedBook = book;
                    break;
                }
            }
            return returnedBook;
        }
    }
}
