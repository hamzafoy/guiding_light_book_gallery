using GuidingLightBookGallery.Models;

namespace GuidingLightBookGallery.Data
{
    public class BookRepository
    {
        private static Book[] _books = new Book[]
        {
            new Book()
            {
                Id = 1,
                Title = "Islam and the World",
                Authors = new Author[]
                {
                        new Author() { FirstName = "Sayyed Abul Hasan", LastName = "Ali Nadwi", Role = "Author" },
                        new Author() { FirstName = "Muhammad", LastName = "Kidwai", Role = "Translator" }
                },
                DescriptionHTML = "<p>This book persuasively argues against the premise that Islam is a <em>spent force</em>, reminding readers of its dynamism.</p>",
                PublishingHouse = "UK Islamic Academy",
                PublicationYear = 2005
            },
            new Book()
            {
                Id = 2,
                Title = "Al-Maqasid: Nawawi's Manual on Islam",
                Authors = new Author[]
                {
                    new Author() { FirstName = "Imam Abu Zakariya", LastName = "Nawawi", Role = "Author" },
                    new Author() { FirstName = "Nuh Ha Mim", LastName = "Keller", Role = "Translator"}
                },
                DescriptionHTML = "<p>This book dictates the individually obligated knowledge that a Muslim must know including creed & tenets of worship according to the Shafi'i madhhab</p>",
                PublishingHouse = "Amana Publications",
                PublicationYear = 2003
            },
            new Book()
            {
                Id = 3,
                Title = "Introduction to Islamic Creed: Risalat fi'Ilm al-Tawhid",
                Authors = new Author[]
                {
                    new Author() { FirstName = "Imam Ibrahim", LastName = "al-Bajuri", Role = "Author" },
                    new Author() { FirstName = "Rashad", LastName = "Jameer", Role = "Translator" }
                },
                DescriptionHTML = "<p>This book explores the attributes of Allah, the necessary knowledge regarding the prophets & messengers, & more related to the Islamic creed.</p>",
                PublishingHouse = "Imam Ghazali Institute",
                PublicationYear = 2017 
            }
        };
        public Book[] GetBooks()
        {
            return _books;
        }
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
